using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetIPlayerUI
{
    public partial class iPlayerForm : Form
    {
        Interop iPlayer = new Interop();
        ProgramSet ps;

        public iPlayerForm()
        {
            InitializeComponent();
        }

        private async void RefreshListings(string filter)
        {
            // asynchronous update of program listings
            Application.UseWaitCursor = true;
            WaitState.Visible = true;

            ps = await iPlayer.ProgramsAvailableAsync(filter);
            //ps = await Task<ProgramSet>.Run(() =>
            //{
            //    return iPlayer.ProgramsAvailable(filter);
            //});

            programsDataGridView.DataSource = ps;
            programsDataGridView.DataMember = "Programs";
            FilteredItemCount.Text = ps.Programs.Rows.Count.ToString();

            WaitState.Visible = false;
            Application.UseWaitCursor = false;
        }

        private async void RecordPrograms() 
        {
            List<int> ids = new List<int>();

            foreach(DataGridViewRow r in programsDataGridView.Rows)
            {
                if (r.Selected)
                {
                    ids.Add(Int32.Parse((string)r.Cells[1].Value));
                }
            }
            await iPlayer.RecordProgramsAsync(ids.ToArray<int>());
        }

        private void RecordProgramsButtonClicked(object sender, EventArgs e)
        {
            RecordPrograms();
        }

        private void FilterList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedFilter = ((TreeView)sender).SelectedNode.Name;
            UpdateFilter(selectedFilter);
            UpdateCacheLabel();
        }

        private void iPlayerForm_Load(object sender, EventArgs e)
        {
            const string DEFAULT_FILTER = "TVAllEpisodes";

            // set up initial view of treeview
            FilterList.ExpandAll();
            FilterList.SelectedNode = FilterList.Nodes.Find(DEFAULT_FILTER, true)[0];
            var f = new Font(FilterList.Font.FontFamily, 11.25F);
            FilterList.Nodes["TV"].NodeFont = f;
            FilterList.Nodes["Radio"].NodeFont = f;

            UpdateFilter(DEFAULT_FILTER); // default
            UpdateCacheLabel();
        }

        private void UpdateFilter(string filter)
        {
            string filterArgs;

            if (iPlayer.ProgramFilter.TryGetValue(filter, out filterArgs))
            {
                RefreshListings(filterArgs);
            }
        }

        private async void UpdateCacheLabel()
        {
            string cacheType;
            // TODO: Assumes tree view has only two levels. May need to revisit this. 
            if (FilterList.SelectedNode.Level == 0)
            {
                cacheType = FilterList.SelectedNode.Name;
            }
            else
            {
                cacheType = FilterList.SelectedNode.Parent.Name;
            }

            var age = await iPlayer.GetCacheAgeAsync(cacheType);
            if (age == String.Empty)
            {
                age = "Programs cache has not yet been created.";
            }
            else
            {
                age = "Program cache last updated " + age + " ago.";
            }
            cacheAgeLabel.Text = age;
        }

        private void programsDataGridView_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                e.ToolTipText = ps.Programs[e.RowIndex].Description;
            }
        }

        private void settingsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            settingsDialogControl.Visible = true;
        }

        private async void refreshCacheLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // asynchronous update of program listings
            Application.UseWaitCursor = true;
            WaitState.Visible = true;

            string node = FilterList.SelectedNode.FullPath;
            if (node.IndexOf('\\') != -1)
            { 
                node = node.Substring(0, node.IndexOf('\\'));
            }

            await iPlayer.RefreshCacheAsync(node);

            UpdateFilter(FilterList.SelectedNode.Name);
            UpdateCacheLabel();

            WaitState.Visible = false;
            Application.UseWaitCursor = false;

        }
    }
}