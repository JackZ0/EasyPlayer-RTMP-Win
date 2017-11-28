﻿using System.Drawing;

namespace Client
{
    partial class PlayerForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Snop_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Recode_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OSDShow_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullWindos_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyFreamDecode_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenderRect_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label = new System.Windows.Forms.Label();
            this.StreamURI = new System.Windows.Forms.TextBox();
            this.rtpoverType = new System.Windows.Forms.CheckBox();
            this.HardDecode = new System.Windows.Forms.CheckBox();
            this.CacheFream = new System.Windows.Forms.TrackBar();
            this.PlayerBtn = new System.Windows.Forms.Button();
            this.PlaySound_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CacheFream)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 575);
            this.panel1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Snop_MenuItem,
            this.Recode_MenuItem,
            this.OSDShow_MenuItem,
            this.FullWindos_MenuItem,
            this.KeyFreamDecode_MenuItem,
            this.RenderRect_MenuItem,
            this.PlaySound_MenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 158);
            // 
            // Snop_MenuItem
            // 
            this.Snop_MenuItem.Name = "Snop_MenuItem";
            this.Snop_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.Snop_MenuItem.Text = "截图";
            this.Snop_MenuItem.Click += new System.EventHandler(this.Snop_MenuItem_Click);
            // 
            // Recode_MenuItem
            // 
            this.Recode_MenuItem.Name = "Recode_MenuItem";
            this.Recode_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.Recode_MenuItem.Text = "视频录像";
            this.Recode_MenuItem.Click += new System.EventHandler(this.Recode_MenuItem_Click);
            // 
            // OSDShow_MenuItem
            // 
            this.OSDShow_MenuItem.Name = "OSDShow_MenuItem";
            this.OSDShow_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.OSDShow_MenuItem.Text = "OSD显示";
            this.OSDShow_MenuItem.Click += new System.EventHandler(this.OSDShow_MenuItem_Click);
            // 
            // FullWindos_MenuItem
            // 
            this.FullWindos_MenuItem.Name = "FullWindos_MenuItem";
            this.FullWindos_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.FullWindos_MenuItem.Text = "比例显示";
            this.FullWindos_MenuItem.Click += new System.EventHandler(this.FullWindos_MenuItem_Click);
            // 
            // KeyFreamDecode_MenuItem
            // 
            this.KeyFreamDecode_MenuItem.Name = "KeyFreamDecode_MenuItem";
            this.KeyFreamDecode_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.KeyFreamDecode_MenuItem.Text = "关键帧解码";
            this.KeyFreamDecode_MenuItem.Click += new System.EventHandler(this.KeyFreamDecode_MenuItem_Click);
            // 
            // RenderRect_MenuItem
            // 
            this.RenderRect_MenuItem.Name = "RenderRect_MenuItem";
            this.RenderRect_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.RenderRect_MenuItem.Text = "渲染区域";
            this.RenderRect_MenuItem.Click += new System.EventHandler(this.RenderRect_MenuItem_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(12, 578);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(88, 17);
            this.Label.TabIndex = 4;
            this.Label.Text = "RTSP地址：";
            // 
            // StreamURI
            // 
            this.StreamURI.Location = new System.Drawing.Point(90, 576);
            this.StreamURI.Name = "StreamURI";
            this.StreamURI.Size = new System.Drawing.Size(312, 23);
            this.StreamURI.TabIndex = 3;
            this.StreamURI.Text = "rtsp://admin:a1234567@192.168.90.32:554/h264/ch1/main/av_stream";
            // 
            // rtpoverType
            // 
            this.rtpoverType.AutoSize = true;
            this.rtpoverType.Location = new System.Drawing.Point(463, 578);
            this.rtpoverType.Name = "rtpoverType";
            this.rtpoverType.Size = new System.Drawing.Size(51, 21);
            this.rtpoverType.TabIndex = 5;
            this.rtpoverType.Text = "TCP";
            this.rtpoverType.UseVisualStyleBackColor = true;
            // 
            // HardDecode
            // 
            this.HardDecode.AutoSize = true;
            this.HardDecode.Location = new System.Drawing.Point(408, 578);
            this.HardDecode.Name = "HardDecode";
            this.HardDecode.Size = new System.Drawing.Size(59, 21);
            this.HardDecode.TabIndex = 6;
            this.HardDecode.Text = "硬解";
            this.HardDecode.UseVisualStyleBackColor = true;
            // 
            // CacheFream
            // 
            this.CacheFream.Location = new System.Drawing.Point(530, 576);
            this.CacheFream.Maximum = 30;
            this.CacheFream.Minimum = 6;
            this.CacheFream.Name = "CacheFream";
            this.CacheFream.Size = new System.Drawing.Size(190, 45);
            this.CacheFream.TabIndex = 7;
            this.CacheFream.Value = 10;
            this.CacheFream.ValueChanged += new System.EventHandler(this.CacheFream_ValueChanged);
            // 
            // PlayerBtn
            // 
            this.PlayerBtn.Location = new System.Drawing.Point(718, 576);
            this.PlayerBtn.Name = "PlayerBtn";
            this.PlayerBtn.Size = new System.Drawing.Size(75, 23);
            this.PlayerBtn.TabIndex = 8;
            this.PlayerBtn.Text = "播放";
            this.PlayerBtn.UseVisualStyleBackColor = true;
            this.PlayerBtn.Click += new System.EventHandler(this.PlayerBtn_Click);
            // 
            // PlaySound_MenuItem
            // 
            this.PlaySound_MenuItem.Name = "PlaySound_MenuItem";
            this.PlaySound_MenuItem.Size = new System.Drawing.Size(152, 22);
            this.PlaySound_MenuItem.Text = "播放音频";
            this.PlaySound_MenuItem.Click += new System.EventHandler(this.PlaySound_MenuItem_Click);
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.PlayerBtn);
            this.Controls.Add(this.StreamURI);
            this.Controls.Add(this.CacheFream);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.rtpoverType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HardDecode);
            this.Font = new System.Drawing.Font("Courier New", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "PlayerForm";
            this.Text = "EasyPlayer RTSP播放器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayerForm_FormClosing);
            this.Load += new System.EventHandler(this.PlayerForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CacheFream)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox StreamURI;
        private System.Windows.Forms.CheckBox rtpoverType;
        private System.Windows.Forms.CheckBox HardDecode;
        private System.Windows.Forms.TrackBar CacheFream;
        private System.Windows.Forms.Button PlayerBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Snop_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Recode_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem OSDShow_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem FullWindos_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem KeyFreamDecode_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenderRect_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlaySound_MenuItem;
    }
}

