namespace HGDS.DE.JanReichelt.Practice265
{
    partial class Frm_Practice265
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_canvas = new System.Windows.Forms.Panel();
            this.cmd_step = new System.Windows.Forms.Button();
            this.num_maxCount = new System.Windows.Forms.NumericUpDown();
            this.lbl_info1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_maxCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_canvas
            // 
            this.pnl_canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_canvas.Location = new System.Drawing.Point(12, 12);
            this.pnl_canvas.Name = "pnl_canvas";
            this.pnl_canvas.Size = new System.Drawing.Size(776, 410);
            this.pnl_canvas.TabIndex = 0;
            this.pnl_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_canvas_Paint);
            // 
            // cmd_step
            // 
            this.cmd_step.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmd_step.Location = new System.Drawing.Point(695, 430);
            this.cmd_step.Name = "cmd_step";
            this.cmd_step.Size = new System.Drawing.Size(93, 23);
            this.cmd_step.TabIndex = 3;
            this.cmd_step.Text = "nächster Schritt";
            this.cmd_step.UseVisualStyleBackColor = true;
            this.cmd_step.Click += new System.EventHandler(this.cmd_step_Click);
            // 
            // num_maxCount
            // 
            this.num_maxCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.num_maxCount.Location = new System.Drawing.Point(101, 433);
            this.num_maxCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_maxCount.Name = "num_maxCount";
            this.num_maxCount.Size = new System.Drawing.Size(59, 20);
            this.num_maxCount.TabIndex = 4;
            this.num_maxCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbl_info1
            // 
            this.lbl_info1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_info1.AutoSize = true;
            this.lbl_info1.Location = new System.Drawing.Point(9, 435);
            this.lbl_info1.Name = "lbl_info1";
            this.lbl_info1.Size = new System.Drawing.Size(86, 13);
            this.lbl_info1.TabIndex = 5;
            this.lbl_info1.Text = "Maximale Anzahl";
            // 
            // Frm_Practice265
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.lbl_info1);
            this.Controls.Add(this.num_maxCount);
            this.Controls.Add(this.cmd_step);
            this.Controls.Add(this.pnl_canvas);
            this.Name = "Frm_Practice265";
            this.Text = "Step: ";
            ((System.ComponentModel.ISupportInitialize)(this.num_maxCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_canvas;
        private System.Windows.Forms.Button cmd_step;
        private System.Windows.Forms.NumericUpDown num_maxCount;
        private System.Windows.Forms.Label lbl_info1;
    }
}

