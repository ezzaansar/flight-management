namespace SE3
{
    partial class DisplayFlight
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
            panel1 = new Panel();
            label1 = new Label();
            FlightsGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FlightsGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 143, 119);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1121, 125);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(411, 46);
            label1.Name = "label1";
            label1.Size = new Size(286, 41);
            label1.TabIndex = 0;
            label1.Text = "DISPLAY FLIGHTS";
            label1.Click += label1_Click;
            // 
            // FlightsGridView
            // 
            FlightsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FlightsGridView.Location = new Point(122, 150);
            FlightsGridView.Name = "FlightsGridView";
            FlightsGridView.RowHeadersWidth = 51;
            FlightsGridView.Size = new Size(875, 397);
            FlightsGridView.TabIndex = 1;
            // 
            // DisplayFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 599);
            Controls.Add(FlightsGridView);
            Controls.Add(panel1);
            Name = "DisplayFlight";
            Text = "displayflight";
            Load += displayflight_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FlightsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView FlightsGridView;
    }
}