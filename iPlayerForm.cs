using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            ps = await Task<ProgramSet>.Run(() =>
            {
                return iPlayer.ProgramsAvailable(filter);
            });

            ProgramsGridView.DataSource = ps;
            ProgramsGridView.DataMember = "Programs";
            FilteredItemCount.Text = ps.Programs.Rows.Count.ToString();

            WaitState.Visible = false;
            Application.UseWaitCursor = false;
        }

        private void RecordPrograms() 
        {
            List<int> ids = new List<int>();

            foreach(DataGridViewRow r in ProgramsGridView.Rows)
            {
                if (r.Selected)
                {
                    ids.Add(Int32.Parse((string)r.Cells[1].Value));
                }
            }
            iPlayer.RecordPrograms(ids.ToArray<int>());
        }

        #region Form hookups
        private void RefreshListingsLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshListings("");
        }

        private void RecordProgramsButtonClicked(object sender, EventArgs e)
        {
            RecordPrograms();
        }
        #endregion

        private void FilterList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedFilter = ((TreeView)sender).SelectedNode.Name;
            string filterArgs = "";

            if (iPlayer.ProgramFilter.TryGetValue(selectedFilter, out filterArgs))
            {
                RefreshListings(filterArgs);
            }
        }

        private void iPlayerForm_Load(object sender, EventArgs e)
        {
            // set up initial view of treeview
            FilterList.ExpandAll();
            FilterList.SelectedNode = FilterList.Nodes.Find("TVAllEpisodes", true)[0];
            Font f = new Font(FilterList.Font.FontFamily, 11.25F);
            FilterList.Nodes["TV"].NodeFont = f;
            FilterList.Nodes["Radio"].NodeFont = f;

            RefreshListings(iPlayer.ProgramFilter["TVAllEpisodes"]);
        }
    }
}
