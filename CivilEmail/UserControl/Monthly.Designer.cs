namespace CivilEmail.UserControl
{
    partial class Monthly
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.seAydaBir = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.seGunu = new DevExpress.XtraEditors.SpinEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.seAydaBirikinci = new DevExpress.XtraEditors.SpinEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.chcHerilk = new DevExpress.XtraEditors.CheckEdit();
            this.chcHekikinci = new DevExpress.XtraEditors.CheckEdit();
            this.cboZaman = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboGun = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.seAydaBir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seGunu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAydaBirikinci.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcHerilk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcHekikinci.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboZaman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGun.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // seAydaBir
            // 
            this.seAydaBir.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seAydaBir.Location = new System.Drawing.Point(83, 8);
            this.seAydaBir.Name = "seAydaBir";
            this.seAydaBir.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAydaBir.Size = new System.Drawing.Size(54, 20);
            this.seAydaBir.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ayda bir, ayın";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = ". günü";
            // 
            // seGunu
            // 
            this.seGunu.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seGunu.Location = new System.Drawing.Point(252, 8);
            this.seGunu.Name = "seGunu";
            this.seGunu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seGunu.Size = new System.Drawing.Size(54, 20);
            this.seGunu.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ayda bir, ayın";
            // 
            // seAydaBirikinci
            // 
            this.seAydaBirikinci.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seAydaBirikinci.Location = new System.Drawing.Point(83, 38);
            this.seAydaBirikinci.Name = "seAydaBirikinci";
            this.seAydaBirikinci.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAydaBirikinci.Size = new System.Drawing.Size(54, 20);
            this.seAydaBirikinci.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = " günü";
            // 
            // chcHerilk
            // 
            this.chcHerilk.EditValue = true;
            this.chcHerilk.Location = new System.Drawing.Point(3, 8);
            this.chcHerilk.Name = "chcHerilk";
            this.chcHerilk.Properties.Caption = "Her";
            this.chcHerilk.Size = new System.Drawing.Size(63, 19);
            this.chcHerilk.TabIndex = 8;
            this.chcHerilk.CheckedChanged += new System.EventHandler(this.chcHerilk_CheckedChanged);
            // 
            // chcHekikinci
            // 
            this.chcHekikinci.Location = new System.Drawing.Point(3, 38);
            this.chcHekikinci.Name = "chcHekikinci";
            this.chcHekikinci.Properties.Caption = "Her";
            this.chcHekikinci.Size = new System.Drawing.Size(63, 19);
            this.chcHekikinci.TabIndex = 9;
            this.chcHekikinci.CheckedChanged += new System.EventHandler(this.chcHekikinci_CheckedChanged);
            // 
            // cboZaman
            // 
            this.cboZaman.EditValue = "İlk";
            this.cboZaman.Location = new System.Drawing.Point(252, 38);
            this.cboZaman.Name = "cboZaman";
            this.cboZaman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboZaman.Properties.Items.AddRange(new object[] {
            "İlk",
            "İkinci",
            "Üçüncü",
            "Dörtüncü",
            "Son"});
            this.cboZaman.Size = new System.Drawing.Size(66, 20);
            this.cboZaman.TabIndex = 10;
            // 
            // cboGun
            // 
            this.cboGun.EditValue = "Pazartesi";
            this.cboGun.Location = new System.Drawing.Point(324, 38);
            this.cboGun.Name = "cboGun";
            this.cboGun.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGun.Properties.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.cboGun.Size = new System.Drawing.Size(100, 20);
            this.cboGun.TabIndex = 10;
            // 
            // Monthly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboGun);
            this.Controls.Add(this.cboZaman);
            this.Controls.Add(this.chcHekikinci);
            this.Controls.Add(this.chcHerilk);
            this.Controls.Add(this.seGunu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seAydaBirikinci);
            this.Controls.Add(this.seAydaBir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "Monthly";
            this.Size = new System.Drawing.Size(601, 74);
            ((System.ComponentModel.ISupportInitialize)(this.seAydaBir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seGunu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAydaBirikinci.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcHerilk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chcHekikinci.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboZaman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGun.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public DevExpress.XtraEditors.SpinEdit seAydaBir;
        public DevExpress.XtraEditors.SpinEdit seGunu;
        public DevExpress.XtraEditors.SpinEdit seAydaBirikinci;
        public DevExpress.XtraEditors.CheckEdit chcHerilk;
        public DevExpress.XtraEditors.CheckEdit chcHekikinci;
        public DevExpress.XtraEditors.ComboBoxEdit cboZaman;
        public DevExpress.XtraEditors.ComboBoxEdit cboGun;
    }
}
