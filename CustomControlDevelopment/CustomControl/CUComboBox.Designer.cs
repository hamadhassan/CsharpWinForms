namespace CustomControl
{
    partial class CUComboBox
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
            this.cmbxList = new System.Windows.Forms.ComboBox();
            this.txtbxSelected = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbxList
            // 
            this.cmbxList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxList.FormattingEnabled = true;
            this.cmbxList.Location = new System.Drawing.Point(4, 37);
            this.cmbxList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbxList.Name = "cmbxList";
            this.cmbxList.Size = new System.Drawing.Size(197, 28);
            this.cmbxList.TabIndex = 1;
            this.cmbxList.SelectedIndexChanged += new System.EventHandler(this.cmbxList_SelectedIndexChanged);
            // 
            // txtbxSelected
            // 
            this.txtbxSelected.Location = new System.Drawing.Point(4, 3);
            this.txtbxSelected.Name = "txtbxSelected";
            this.txtbxSelected.Size = new System.Drawing.Size(197, 26);
            this.txtbxSelected.TabIndex = 0;
            this.txtbxSelected.Leave += new System.EventHandler(this.txtbxSelected_Leave);
            // 
            // CUComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtbxSelected);
            this.Controls.Add(this.cmbxList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CUComboBox";
            this.Size = new System.Drawing.Size(207, 89);
            this.Load += new System.EventHandler(this.CUComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxList;
        private System.Windows.Forms.TextBox txtbxSelected;
    }
}
