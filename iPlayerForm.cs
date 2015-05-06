﻿using System;
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

        private async void RefreshListings(string filter, bool forceRefresh = false)
        {
            // asynchronous update of program listings
            Application.UseWaitCursor = true;
            WaitState.Visible = true;

            ps = await Task<ProgramSet>.Run(() =>
            {
                return iPlayer.ProgramsAvailable(filter, forceRefresh);
            });

            programsDataGridView.DataSource = ps;
            programsDataGridView.DataMember = "Programs";
            FilteredItemCount.Text = ps.Programs.Rows.Count.ToString();

            WaitState.Visible = false;
            Application.UseWaitCursor = false;
        }

        private void RecordPrograms() 
        {
            List<int> ids = new List<int>();

            foreach(DataGridViewRow r in programsDataGridView.Rows)
            {
                if (r.Selected)
                {
                    ids.Add(Int32.Parse((string)r.Cells[1].Value));
                }
            }
            iPlayer.RecordPrograms(ids.ToArray<int>());
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

        private void UpdateFilter(string filter, bool forceRefresh = false)
        {
            string filterArgs;

            if (iPlayer.ProgramFilter.TryGetValue(filter, out filterArgs))
            {
                RefreshListings(filterArgs, forceRefresh);
            }
        }

        private void UpdateCacheLabel()
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

            var age = iPlayer.GetCacheAge(cacheType);
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

        private void refreshCacheLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO: I've screwed this up. Need to properly force refresh
            UpdateFilter(FilterList.SelectedNode.Name, true);
            UpdateCacheLabel();
        }
    }
}
