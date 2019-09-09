namespace ChessBoardGUI
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
            this.lbl_info = new System.Windows.Forms.Label();
            this.cmbbx_pieces = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(32, 22);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(1023, 32);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "Select a piece from the drop down, click a square, I will show you all legal move" +
    "s";
            // 
            // cmbbx_pieces
            // 
            this.cmbbx_pieces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_pieces.FormattingEnabled = true;
            this.cmbbx_pieces.Items.AddRange(new object[] {
            "King",
            "Queen",
            "Bishop",
            "Knight",
            "Rook"});
            this.cmbbx_pieces.Location = new System.Drawing.Point(1098, 15);
            this.cmbbx_pieces.Name = "cmbbx_pieces";
            this.cmbbx_pieces.Size = new System.Drawing.Size(224, 39);
            this.cmbbx_pieces.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(38, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 1000);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 1107);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbbx_pieces);
            this.Controls.Add(this.lbl_info);
            this.Name = "Form1";
            this.Text = "Chess Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.ComboBox cmbbx_pieces;
        private System.Windows.Forms.Panel panel1;
    }
}

