namespace CivilEmail.UserControl
{
    partial class Weekly
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

        public bool Deneme
        {
            get
            {
                return chcPazar.Checked;
            }
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.speHaftadaBir = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chcPazartesi = new DevExpress.XtraEditors.CheckEdit();
            this.chcSali = new DevExpress.XtraEditors.CheckEdit();
            this.chcCarsamba = new DevExpress.XtraEditors.CheckEdit();
            this.chcPersembe = new DevExpress.XtraEditors.CheckEdit();
            this.chcCuma = new DevExpress.XtraEditors.CheckEdit();
            this.chcCumartesi = new DevExpress.XtraEditors.CheckEdit();
            this.chcPazar = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.speHaftadaBir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcPazartesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcSali.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcCarsamba.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcPersembe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcCuma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcCumartesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcPazar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // speHaftadaBir
            // 
            this.speHaftadaBir.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speHaftadaBir.Location = new System.Drawing.Point(83, 10);
            this.speHaftadaBir.Name = "speHaftadaBir";
            this.speHaftadaBir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speHaftadaBir.Size = new System.Drawing.Size(54, 20);
            this.speHaftadaBir.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Haftada bir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Her";
            // 
            // chcPazartesi
            // 
            this.chcPazartesi.Location = new System.Drawing.Point(15, 38);
            this.chcPazartesi.Name = "chcPazartesi";
            this.chcPazartesi.Properties.Caption = "Pazartesi";
            this.chcPazartesi.Size = new System.Drawing.Size(75, 19);
            this.chcPazartesi.TabIndex = 5;
            this.chcPazartesi.CheckedChanged += new System.EventHandler(this.chcPazar_CheckedChanged);
            // 
            // chcSali
            // 
            this.chcSali.Location = new System.Drawing.Point(96, 38);
            this.chcSali.Name = "chcSali";
            this.chcSali.Properties.Caption = "Salı";
            this.chcSali.Size = new System.Drawing.Size(75, 19);
            this.chcSali.TabIndex = 6;
            this.chcSali.CheckedChanged += new System.EventHandler(this.chcPazar_CheckedChanged);
            // 
            // chcCarsamba
            // 
            this.chcCarsamba.Location = new System.Drawing.Point(146, 38);
            this.chcCarsamba.Name = "chcCarsamba";
            this.chcCarsamba.Properties.Caption = "Çarşamba";
            this.chcCarsamba.Size = new System.Drawing.Size(75, 19);
            this.chcCarsamba.TabIndex = 7;
            this.chcCarsamba.CheckedChanged += new System.EventHandler(this.chcPazar_CheckedChanged);
            // 
            // chcPersembe
            // 
            this.chcPersembe.Location = new System.Drawing.Point(227, 38);
            this.chcPersembe.Name = "chcPersembe";
            this.chcPersembe.Properties.Caption = "Perşembe";
            this.chcPersembe.Size = new System.Drawing.Size(75, 19);
            this.chcPersembe.TabIndex = 8;
            this.chcPersembe.CheckedChanged += new System.EventHandler(this.chcPazar_CheckedChanged);
            // 
            // chcCuma
            // 
            this.chcCuma.Location = new System.Drawing.Point(308, 38);
            this.chcCuma.Name = "chcCuma";
            this.chcCuma.Properties.Caption = "Cuma";
            this.chcCuma.Size = new System.Drawing.Size(75, 19);
            this.chcCuma.TabIndex = 9;
            this.chcCuma.CheckedChanged += new System.EventHandler(this.chcPazar_CheckedChanged);
            // 
            // chcCumartesi
            // 
            this.chcCumartesi.Location = new System.Drawing.Point(367, 38);
            this.chcCumartesi.Name = "chcCumartesi";
            this.chcCumartesi.Properties.Caption = "Cumartesi";
            this.chcCumartesi.Size = new System.Drawing.Size(75, 19);
            this.chcCumartesi.TabIndex = 10;
            this.chcCumartesi.CheckedChanged += new System.EventHandler(this.chcPazar_CheckedChanged);
            // 
            // chcPazar
            // 
            this.chcPazar.Location = new System.Drawing.Point(448, 38);
            this.chcPazar.Name = "chcPazar";
            this.chcPazar.Properties.Caption = "Pazar";
            this.chcPazar.Size = new System.Drawing.Size(75, 19);
            this.chcPazar.TabIndex = 11;
            this.chcPazar.CheckedChanged += new System.EventHandler(this.chcPazar_CheckedChanged);
            // 
            // Weekly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chcPazar);
            this.Controls.Add(this.chcCumartesi);
            this.Controls.Add(this.chcCuma);
            this.Controls.Add(this.chcPersembe);
            this.Controls.Add(this.chcCarsamba);
            this.Controls.Add(this.chcSali);
            this.Controls.Add(this.chcPazartesi);
            this.Controls.Add(this.speHaftadaBir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Weekly";
            this.Size = new System.Drawing.Size(605, 72);
            this.Load += new System.EventHandler(this.Weekly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.speHaftadaBir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcPazartesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcSali.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcCarsamba.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcPersembe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcCuma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcCumartesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcPazar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SpinEdit speHaftadaBir;
        public DevExpress.XtraEditors.CheckEdit chcPazartesi;
        public DevExpress.XtraEditors.CheckEdit chcSali;
        public DevExpress.XtraEditors.CheckEdit chcCarsamba;
        public DevExpress.XtraEditors.CheckEdit chcPersembe;
        public DevExpress.XtraEditors.CheckEdit chcCuma;
        public DevExpress.XtraEditors.CheckEdit chcCumartesi;
        public DevExpress.XtraEditors.CheckEdit chcPazar;
    }
}
