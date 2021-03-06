﻿namespace DoccameraOcx
{
    partial class DoccameraOcx
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoccameraOcx));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sdnDual = new AxsdnDualCameraLivenessLib.AxsdnDualCameraLiveness();
            this.plShowMsg = new System.Windows.Forms.Panel();
            this.btnAgain = new System.Windows.Forms.Button();
            this.lbmsg = new System.Windows.Forms.Label();
            this.sdnZGOcx = new AxCmCaptureOcxLib.AxCmCaptureOcx();
            this.axPrinter1 = new AxVehPlatForm.AxPrinter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdnDual)).BeginInit();
            this.plShowMsg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdnZGOcx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axPrinter1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.sdnDual);
            this.panel1.Controls.Add(this.plShowMsg);
            this.panel1.Controls.Add(this.sdnZGOcx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 443);
            this.panel1.TabIndex = 0;
            // 
            // sdnDual
            // 
            this.sdnDual.Enabled = true;
            this.sdnDual.Location = new System.Drawing.Point(3, 14);
            this.sdnDual.Name = "sdnDual";
            this.sdnDual.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("sdnDual.OcxState")));
            this.sdnDual.Size = new System.Drawing.Size(150, 75);
            this.sdnDual.TabIndex = 3;
            this.sdnDual.sdnOnCaptureStatus += new AxsdnDualCameraLivenessLib._DsdnDualCameraLivenessEvents_sdnOnCaptureStatusEventHandler(this.sdnDual_sdnOnCaptureStatus);
            this.sdnDual.OnCaptureSuccessCallbackHandler += new System.EventHandler(this.sdnDual_OnCaptureSuccessCallbackHandler);
            // 
            // plShowMsg
            // 
            this.plShowMsg.BackColor = System.Drawing.Color.White;
            this.plShowMsg.Controls.Add(this.axPrinter1);
            this.plShowMsg.Controls.Add(this.btnAgain);
            this.plShowMsg.Controls.Add(this.lbmsg);
            this.plShowMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plShowMsg.Location = new System.Drawing.Point(0, 393);
            this.plShowMsg.Name = "plShowMsg";
            this.plShowMsg.Size = new System.Drawing.Size(629, 50);
            this.plShowMsg.TabIndex = 2;
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(134, 14);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(52, 23);
            this.btnAgain.TabIndex = 2;
            this.btnAgain.Text = "比对";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Visible = false;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // lbmsg
            // 
            this.lbmsg.AutoSize = true;
            this.lbmsg.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbmsg.ForeColor = System.Drawing.Color.DarkRed;
            this.lbmsg.Location = new System.Drawing.Point(215, 14);
            this.lbmsg.Name = "lbmsg";
            this.lbmsg.Size = new System.Drawing.Size(186, 28);
            this.lbmsg.TabIndex = 0;
            this.lbmsg.Text = "开始活体检测";
            // 
            // sdnZGOcx
            // 
            this.sdnZGOcx.Enabled = true;
            this.sdnZGOcx.Location = new System.Drawing.Point(3, 117);
            this.sdnZGOcx.Name = "sdnZGOcx";
            this.sdnZGOcx.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("sdnZGOcx.OcxState")));
            this.sdnZGOcx.Size = new System.Drawing.Size(88, 128);
            this.sdnZGOcx.TabIndex = 0;
            // 
            // axPrinter1
            // 
            this.axPrinter1.Enabled = true;
            this.axPrinter1.Location = new System.Drawing.Point(426, 6);
            this.axPrinter1.Name = "axPrinter1";
            this.axPrinter1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPrinter1.OcxState")));
            this.axPrinter1.Size = new System.Drawing.Size(200, 44);
            this.axPrinter1.TabIndex = 3;
            // 
            // DoccameraOcx
            // 
            this.Controls.Add(this.panel1);
            this.Name = "DoccameraOcx";
            this.Size = new System.Drawing.Size(629, 443);
            this.Load += new System.EventHandler(this.DoccameraOcx_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sdnDual)).EndInit();
            this.plShowMsg.ResumeLayout(false);
            this.plShowMsg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sdnZGOcx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axPrinter1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private AxCmCaptureOcxLib.AxCmCaptureOcx sdnZGOcx;
        private System.Windows.Forms.Panel plShowMsg;
        private System.Windows.Forms.Label lbmsg;
        private AxsdnDualCameraLivenessLib.AxsdnDualCameraLiveness sdnDual;
        private System.Windows.Forms.Button btnAgain;
        private AxVehPlatForm.AxPrinter axPrinter1;
    }
}
