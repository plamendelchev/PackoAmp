namespace MP3PlayerPlanel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.trbTime = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblYear = new System.Windows.Forms.Label();
            this.panelClose = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblPerformer = new System.Windows.Forms.Label();
            this.flowPanelTime = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Label();
            this.flowPanelControls = new System.Windows.Forms.FlowLayoutPanel();
            this.volumeSlider = new NAudio.Gui.VolumeSlider();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelAddSongs = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.chkShuffle = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbSongImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trbTime)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelClose.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowPanelTime.SuspendLayout();
            this.flowPanelControls.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelAddSongs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSongImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSongs
            // 
            this.lbSongs.BackColor = System.Drawing.Color.White;
            this.lbSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSongs.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.ItemHeight = 15;
            this.lbSongs.Location = new System.Drawing.Point(856, 1);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(262, 450);
            this.lbSongs.TabIndex = 6;
            this.lbSongs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbSongs_KeyDown);
            this.lbSongs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSongs_DoubleClick);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentTime.Location = new System.Drawing.Point(3, 0);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(32, 17);
            this.lblCurrentTime.TabIndex = 9;
            this.lblCurrentTime.Text = "0:00";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalTime.Location = new System.Drawing.Point(58, 0);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(32, 17);
            this.lblTotalTime.TabIndex = 9;
            this.lblTotalTime.Text = "0:00";
            // 
            // trbTime
            // 
            this.trbTime.LargeChange = 10;
            this.trbTime.Location = new System.Drawing.Point(223, 168);
            this.trbTime.Maximum = 100;
            this.trbTime.Name = "trbTime";
            this.trbTime.Size = new System.Drawing.Size(405, 45);
            this.trbTime.TabIndex = 10;
            this.trbTime.TickFrequency = 0;
            this.trbTime.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trbTime.Scroll += new System.EventHandler(this.trbTime_Scroll);
            this.trbTime.ValueChanged += new System.EventHandler(this.trbTime_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(180)))));
            this.panelTop.Controls.Add(this.lblYear);
            this.panelTop.Controls.Add(this.panelClose);
            this.panelTop.Controls.Add(this.panel2);
            this.panelTop.Controls.Add(this.flowPanelTime);
            this.panelTop.Controls.Add(this.pbLogo);
            this.panelTop.Controls.Add(this.lblGenre);
            this.panelTop.Controls.Add(this.pbSongImg);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(850, 232);
            this.panelTop.TabIndex = 12;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // lblYear
            // 
            this.lblYear.AutoEllipsis = true;
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Open Sans", 11F);
            this.lblYear.Location = new System.Drawing.Point(796, 198);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(39, 20);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year";
            // 
            // panelClose
            // 
            this.panelClose.Controls.Add(this.btnClose);
            this.panelClose.Controls.Add(this.button1);
            this.panelClose.Location = new System.Drawing.Point(757, 7);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(87, 43);
            this.panelClose.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblAlbum);
            this.panel2.Controls.Add(this.lblPerformer);
            this.panel2.Location = new System.Drawing.Point(293, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 129);
            this.panel2.TabIndex = 24;
            // 
            // lblAlbum
            // 
            this.lblAlbum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlbum.AutoEllipsis = true;
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Open Sans", 14F);
            this.lblAlbum.Location = new System.Drawing.Point(1, 78);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(167, 26);
            this.lblAlbum.TabIndex = 0;
            this.lblAlbum.Text = "No songs opened";
            this.lblAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerformer
            // 
            this.lblPerformer.AutoEllipsis = true;
            this.lblPerformer.AutoSize = true;
            this.lblPerformer.Font = new System.Drawing.Font("Open Sans", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPerformer.Location = new System.Drawing.Point(-3, 26);
            this.lblPerformer.Name = "lblPerformer";
            this.lblPerformer.Size = new System.Drawing.Size(98, 52);
            this.lblPerformer.TabIndex = 2;
            this.lblPerformer.Text = "Title";
            // 
            // flowPanelTime
            // 
            this.flowPanelTime.Controls.Add(this.lblCurrentTime);
            this.flowPanelTime.Controls.Add(this.label1);
            this.flowPanelTime.Controls.Add(this.lblTotalTime);
            this.flowPanelTime.Location = new System.Drawing.Point(293, 198);
            this.flowPanelTime.Name = "flowPanelTime";
            this.flowPanelTime.Size = new System.Drawing.Size(158, 27);
            this.flowPanelTime.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "-";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoEllipsis = true;
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Open Sans", 11F);
            this.lblGenre.Location = new System.Drawing.Point(549, 198);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(51, 20);
            this.lblGenre.TabIndex = 0;
            this.lblGenre.Text = "Genre";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Open Sans", 16F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(330, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(131, 30);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Song Name";
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Font = new System.Drawing.Font("Webdings", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(180)))));
            this.btnPlay.Location = new System.Drawing.Point(114, 0);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(114, 80);
            this.btnPlay.TabIndex = 17;
            this.btnPlay.Text = "4";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.AutoSize = true;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("Webdings", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(180)))));
            this.btnStop.Location = new System.Drawing.Point(228, 0);
            this.btnStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(114, 80);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "<";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Webdings", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(180)))));
            this.btnNext.Location = new System.Drawing.Point(342, 0);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(114, 80);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "8";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.AutoSize = true;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.Font = new System.Drawing.Font("Webdings", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(180)))));
            this.btnPrev.Location = new System.Drawing.Point(0, 0);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(114, 80);
            this.btnPrev.TabIndex = 17;
            this.btnPrev.Text = "7";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // flowPanelControls
            // 
            this.flowPanelControls.Controls.Add(this.btnPrev);
            this.flowPanelControls.Controls.Add(this.btnPlay);
            this.flowPanelControls.Controls.Add(this.btnStop);
            this.flowPanelControls.Controls.Add(this.btnNext);
            this.flowPanelControls.Location = new System.Drawing.Point(197, 68);
            this.flowPanelControls.Name = "flowPanelControls";
            this.flowPanelControls.Size = new System.Drawing.Size(456, 84);
            this.flowPanelControls.TabIndex = 18;
            // 
            // volumeSlider
            // 
            this.volumeSlider.Location = new System.Drawing.Point(377, 219);
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(96, 16);
            this.volumeSlider.TabIndex = 15;
            this.volumeSlider.VolumeChanged += new System.EventHandler(this.volumeSlider_VolumeChanged);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panelBottom.Controls.Add(this.lblTitle);
            this.panelBottom.Controls.Add(this.flowPanelControls);
            this.panelBottom.Controls.Add(this.chkMute);
            this.panelBottom.Controls.Add(this.chkShuffle);
            this.panelBottom.Controls.Add(this.volumeSlider);
            this.panelBottom.Controls.Add(this.trbTime);
            this.panelBottom.Location = new System.Drawing.Point(0, 231);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(850, 260);
            this.panelBottom.TabIndex = 22;
            this.panelBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBottom_MouseDown);
            // 
            // panelAddSongs
            // 
            this.panelAddSongs.BackColor = System.Drawing.Color.White;
            this.panelAddSongs.Controls.Add(this.btnAdd);
            this.panelAddSongs.Controls.Add(this.btnRemove);
            this.panelAddSongs.Controls.Add(this.btnRemoveAll);
            this.panelAddSongs.Controls.Add(this.btnAddFolder);
            this.panelAddSongs.Location = new System.Drawing.Point(856, 453);
            this.panelAddSongs.Name = "panelAddSongs";
            this.panelAddSongs.Size = new System.Drawing.Size(262, 28);
            this.panelAddSongs.TabIndex = 23;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::PackoAmp.Properties.Resources.plusicon;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = global::PackoAmp.Properties.Resources.minusicon;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(44, 10);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(20, 10);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.BackgroundImage = global::PackoAmp.Properties.Resources.minusicon;
            this.btnRemoveAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveAll.FlatAppearance.BorderSize = 0;
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.Location = new System.Drawing.Point(230, 10);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(21, 10);
            this.btnRemoveAll.TabIndex = 21;
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.BackgroundImage = global::PackoAmp.Properties.Resources.plusicon;
            this.btnAddFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFolder.FlatAppearance.BorderSize = 0;
            this.btnAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolder.Location = new System.Drawing.Point(189, 3);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(36, 23);
            this.btnAddFolder.TabIndex = 17;
            this.btnAddFolder.UseVisualStyleBackColor = false;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // chkMute
            // 
            this.chkMute.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMute.BackgroundImage = global::PackoAmp.Properties.Resources.muteicon;
            this.chkMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkMute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMute.FlatAppearance.BorderSize = 0;
            this.chkMute.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.chkMute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.chkMute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.chkMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMute.Location = new System.Drawing.Point(293, 207);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(52, 35);
            this.chkMute.TabIndex = 20;
            this.chkMute.UseVisualStyleBackColor = true;
            this.chkMute.CheckedChanged += new System.EventHandler(this.chkMute_CheckedChanged);
            // 
            // chkShuffle
            // 
            this.chkShuffle.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkShuffle.BackgroundImage = global::PackoAmp.Properties.Resources.shuffle;
            this.chkShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShuffle.FlatAppearance.BorderSize = 0;
            this.chkShuffle.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.chkShuffle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.chkShuffle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.chkShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkShuffle.Location = new System.Drawing.Point(511, 207);
            this.chkShuffle.Name = "chkShuffle";
            this.chkShuffle.Size = new System.Drawing.Size(52, 35);
            this.chkShuffle.TabIndex = 20;
            this.chkShuffle.UseVisualStyleBackColor = true;
            this.chkShuffle.CheckedChanged += new System.EventHandler(this.chkShuffle_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::PackoAmp.Properties.Resources.closeicon;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(180)))));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(180)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(180)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(44, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 36);
            this.btnClose.TabIndex = 16;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PackoAmp.Properties.Resources.minimize;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(180)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(180)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(143)))), ((int)(((byte)(180)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(5, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 10);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::PackoAmp.Properties.Resources.logo1;
            this.pbLogo.Location = new System.Drawing.Point(345, 7);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(160, 50);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 14;
            this.pbLogo.TabStop = false;
            // 
            // pbSongImg
            // 
            this.pbSongImg.Location = new System.Drawing.Point(-3, -3);
            this.pbSongImg.Name = "pbSongImg";
            this.pbSongImg.Size = new System.Drawing.Size(244, 235);
            this.pbSongImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSongImg.TabIndex = 13;
            this.pbSongImg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 484);
            this.Controls.Add(this.panelAddSongs);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lbSongs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Maikati";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.trbTime)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelClose.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowPanelTime.ResumeLayout(false);
            this.flowPanelTime.PerformLayout();
            this.flowPanelControls.ResumeLayout(false);
            this.flowPanelControls.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelAddSongs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSongImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.TrackBar trbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pbSongImg;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label btnPlay;
        private System.Windows.Forms.Label btnStop;
        private System.Windows.Forms.Label btnNext;
        private System.Windows.Forms.Label btnPrev;
        private System.Windows.Forms.FlowLayoutPanel flowPanelControls;
        private NAudio.Gui.VolumeSlider volumeSlider;
        private System.Windows.Forms.CheckBox chkShuffle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowPanelTime;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Label lblPerformer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelAddSongs;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.CheckBox chkMute;
    }
}

