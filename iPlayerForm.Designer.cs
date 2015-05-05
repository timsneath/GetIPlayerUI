namespace GetIPlayerUI
{
    partial class iPlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label LoadingLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("All episodes");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("New in last 24 hours");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Childrenʼs TV");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Adult-orientated");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("BBC One");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("BBC Two");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("BBC Three");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("BBC Four");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("BBC Sport");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("TV", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("All Episodes");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("New in last 24 hours");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("BBC Radio 1");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("BBC Radio 2");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("BBC Radio 3");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("BBC Radio 4");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("BBC Radio 4 Extra");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("BBC Radio 5 Live");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("BBC 6 Music");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("BBC World Service");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Radio", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21});
            this.ProgramsGridView = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.episodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.episodeNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programSet = new GetIPlayerUI.ProgramSet();
            this.recordButton = new System.Windows.Forms.Button();
            this.FilterList = new System.Windows.Forms.TreeView();
            this.WaitStateMarquee = new System.Windows.Forms.ProgressBar();
            this.WaitState = new System.Windows.Forms.Panel();
            this.backgroundProcess = new System.Diagnostics.Process();
            this.FilteredItemCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            LoadingLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programSet)).BeginInit();
            this.WaitState.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadingLabel
            // 
            LoadingLabel.AutoSize = true;
            LoadingLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LoadingLabel.ForeColor = System.Drawing.Color.Green;
            LoadingLabel.Location = new System.Drawing.Point(8, 18);
            LoadingLabel.Name = "LoadingLabel";
            LoadingLabel.Size = new System.Drawing.Size(345, 32);
            LoadingLabel.TabIndex = 8;
            LoadingLabel.Text = "Updating Programme Listings...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            label1.Location = new System.Drawing.Point(14, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(392, 37);
            label1.TabIndex = 3;
            label1.Text = "iPlayer Personal Video Recorder";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(200, 622);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(178, 25);
            label2.TabIndex = 9;
            label2.Text = "Programmes found:";
            // 
            // ProgramsGridView
            // 
            this.ProgramsGridView.AllowUserToAddRows = false;
            this.ProgramsGridView.AllowUserToDeleteRows = false;
            this.ProgramsGridView.AllowUserToResizeRows = false;
            this.ProgramsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgramsGridView.AutoGenerateColumns = false;
            this.ProgramsGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProgramsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProgramsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProgramsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProgramsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProgramsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.episodeDataGridViewTextBoxColumn,
            this.seriesNumDataGridViewTextBoxColumn,
            this.episodeNumDataGridViewTextBoxColumn,
            this.channelDataGridViewTextBoxColumn});
            this.ProgramsGridView.DataSource = this.programsBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProgramsGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProgramsGridView.Location = new System.Drawing.Point(201, 70);
            this.ProgramsGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProgramsGridView.Name = "ProgramsGridView";
            this.ProgramsGridView.ReadOnly = true;
            this.ProgramsGridView.RowHeadersVisible = false;
            this.ProgramsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProgramsGridView.Size = new System.Drawing.Size(806, 529);
            this.ProgramsGridView.TabIndex = 0;
            this.ProgramsGridView.MouseHover += new System.EventHandler(this.ProgramsGridView_MouseHover);
            // 
            // Selected
            // 
            this.Selected.DataPropertyName = "Selected";
            this.Selected.HeaderText = "";
            this.Selected.MinimumWidth = 25;
            this.Selected.Name = "Selected";
            this.Selected.ReadOnly = true;
            this.Selected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Selected.Width = 40;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 30;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 56;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Show Title";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 250;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // episodeDataGridViewTextBoxColumn
            // 
            this.episodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.episodeDataGridViewTextBoxColumn.DataPropertyName = "Episode";
            this.episodeDataGridViewTextBoxColumn.FillWeight = 50F;
            this.episodeDataGridViewTextBoxColumn.HeaderText = "Episode";
            this.episodeDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.episodeDataGridViewTextBoxColumn.Name = "episodeDataGridViewTextBoxColumn";
            this.episodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.episodeDataGridViewTextBoxColumn.Width = 200;
            // 
            // seriesNumDataGridViewTextBoxColumn
            // 
            this.seriesNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.seriesNumDataGridViewTextBoxColumn.DataPropertyName = "SeriesNum";
            this.seriesNumDataGridViewTextBoxColumn.HeaderText = "S#";
            this.seriesNumDataGridViewTextBoxColumn.MinimumWidth = 30;
            this.seriesNumDataGridViewTextBoxColumn.Name = "seriesNumDataGridViewTextBoxColumn";
            this.seriesNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.seriesNumDataGridViewTextBoxColumn.Width = 30;
            // 
            // episodeNumDataGridViewTextBoxColumn
            // 
            this.episodeNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.episodeNumDataGridViewTextBoxColumn.DataPropertyName = "EpisodeNum";
            this.episodeNumDataGridViewTextBoxColumn.HeaderText = "E#";
            this.episodeNumDataGridViewTextBoxColumn.MinimumWidth = 30;
            this.episodeNumDataGridViewTextBoxColumn.Name = "episodeNumDataGridViewTextBoxColumn";
            this.episodeNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.episodeNumDataGridViewTextBoxColumn.Width = 30;
            // 
            // channelDataGridViewTextBoxColumn
            // 
            this.channelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.channelDataGridViewTextBoxColumn.DataPropertyName = "Channel";
            this.channelDataGridViewTextBoxColumn.HeaderText = "Channel";
            this.channelDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.channelDataGridViewTextBoxColumn.Name = "channelDataGridViewTextBoxColumn";
            this.channelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // programsBindingSource
            // 
            this.programsBindingSource.DataMember = "Programs";
            this.programsBindingSource.DataSource = this.programSet;
            // 
            // programSet
            // 
            this.programSet.DataSetName = "ProgramSet";
            this.programSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordButton
            // 
            this.recordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.recordButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordButton.Location = new System.Drawing.Point(754, 606);
            this.recordButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(253, 52);
            this.recordButton.TabIndex = 4;
            this.recordButton.Text = "Record Selected Programs";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.RecordProgramsButtonClicked);
            // 
            // FilterList
            // 
            this.FilterList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilterList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterList.HideSelection = false;
            this.FilterList.Indent = 12;
            this.FilterList.Location = new System.Drawing.Point(14, 70);
            this.FilterList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FilterList.Name = "FilterList";
            treeNode1.Name = "TVAllEpisodes";
            treeNode1.Text = "All episodes";
            treeNode2.Name = "TVNewInLast24Hours";
            treeNode2.Text = "New in last 24 hours";
            treeNode3.Name = "ChildrensTV";
            treeNode3.Text = "Childrenʼs TV";
            treeNode4.Name = "AdultOrientated";
            treeNode4.Text = "Adult-orientated";
            treeNode5.Name = "BBC1";
            treeNode5.Text = "BBC One";
            treeNode6.Name = "BBC2";
            treeNode6.Text = "BBC Two";
            treeNode7.Name = "BBC3";
            treeNode7.Text = "BBC Three";
            treeNode8.Name = "BBC4";
            treeNode8.Text = "BBC Four";
            treeNode9.Name = "BBCSport";
            treeNode9.Text = "BBC Sport";
            treeNode10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            treeNode10.Name = "TV";
            treeNode10.Text = "TV";
            treeNode11.Name = "Separator1";
            treeNode11.Text = "";
            treeNode12.Name = "RadioAllEpisodes";
            treeNode12.Text = "All Episodes";
            treeNode13.Name = "RadioNewInLast24Hours";
            treeNode13.Text = "New in last 24 hours";
            treeNode14.Name = "Radio1";
            treeNode14.Text = "BBC Radio 1";
            treeNode15.Name = "Radio2";
            treeNode15.Text = "BBC Radio 2";
            treeNode16.Name = "Radio3";
            treeNode16.Text = "BBC Radio 3";
            treeNode17.Name = "Radio4";
            treeNode17.Text = "BBC Radio 4";
            treeNode18.Name = "Radio4X";
            treeNode18.Text = "BBC Radio 4 Extra";
            treeNode19.Name = "Radio 5";
            treeNode19.Text = "BBC Radio 5 Live";
            treeNode20.Name = "Radio6";
            treeNode20.Text = "BBC 6 Music";
            treeNode21.Name = "RadioWS";
            treeNode21.Text = "BBC World Service";
            treeNode22.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            treeNode22.Name = "Radio";
            treeNode22.Text = "Radio";
            this.FilterList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode22});
            this.FilterList.ShowLines = false;
            this.FilterList.ShowPlusMinus = false;
            this.FilterList.ShowRootLines = false;
            this.FilterList.Size = new System.Drawing.Size(180, 588);
            this.FilterList.TabIndex = 6;
            this.FilterList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FilterList_AfterSelect);
            // 
            // WaitStateMarquee
            // 
            this.WaitStateMarquee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WaitStateMarquee.Location = new System.Drawing.Point(24, 84);
            this.WaitStateMarquee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WaitStateMarquee.MarqueeAnimationSpeed = 50;
            this.WaitStateMarquee.Name = "WaitStateMarquee";
            this.WaitStateMarquee.Size = new System.Drawing.Size(593, 25);
            this.WaitStateMarquee.Step = 5;
            this.WaitStateMarquee.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.WaitStateMarquee.TabIndex = 7;
            // 
            // WaitState
            // 
            this.WaitState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WaitState.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.WaitState.Controls.Add(LoadingLabel);
            this.WaitState.Controls.Add(this.WaitStateMarquee);
            this.WaitState.Location = new System.Drawing.Point(294, 305);
            this.WaitState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WaitState.Name = "WaitState";
            this.WaitState.Size = new System.Drawing.Size(641, 139);
            this.WaitState.TabIndex = 8;
            // 
            // backgroundProcess
            // 
            this.backgroundProcess.EnableRaisingEvents = true;
            this.backgroundProcess.StartInfo.Domain = "";
            this.backgroundProcess.StartInfo.LoadUserProfile = false;
            this.backgroundProcess.StartInfo.Password = null;
            this.backgroundProcess.StartInfo.StandardErrorEncoding = null;
            this.backgroundProcess.StartInfo.StandardOutputEncoding = null;
            this.backgroundProcess.StartInfo.UserName = "";
            this.backgroundProcess.SynchronizingObject = this;
            // 
            // FilteredItemCount
            // 
            this.FilteredItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilteredItemCount.AutoSize = true;
            this.FilteredItemCount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilteredItemCount.ForeColor = System.Drawing.Color.Green;
            this.FilteredItemCount.Location = new System.Drawing.Point(347, 622);
            this.FilteredItemCount.Name = "FilteredItemCount";
            this.FilteredItemCount.Size = new System.Drawing.Size(22, 25);
            this.FilteredItemCount.TabIndex = 10;
            this.FilteredItemCount.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // iPlayerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1052, 674);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FilteredItemCount);
            this.Controls.Add(label2);
            this.Controls.Add(this.WaitState);
            this.Controls.Add(this.FilterList);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(label1);
            this.Controls.Add(this.ProgramsGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "iPlayerForm";
            this.Text = "iPlayer Personal Video Recorder";
            this.Load += new System.EventHandler(this.iPlayerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProgramsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programSet)).EndInit();
            this.WaitState.ResumeLayout(false);
            this.WaitState.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProgramsGridView;
        private System.Windows.Forms.BindingSource programsBindingSource;
        private ProgramSet programSet;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.TreeView FilterList;
        private System.Windows.Forms.ProgressBar WaitStateMarquee;
        private System.Windows.Forms.Panel WaitState;
        private System.Diagnostics.Process backgroundProcess;
        private System.Windows.Forms.Label FilteredItemCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn episodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn episodeNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn channelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

