namespace Merge_Sort
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sortButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.unsortedDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sortedDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warningLabel = new System.Windows.Forms.Label();
            this.fillWithRandomButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unsortedDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sortButton
            // 
            this.sortButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sortButton.Location = new System.Drawing.Point(237, 397);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(106, 22);
            this.sortButton.TabIndex = 0;
            this.sortButton.Text = "Сортировка";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.unsortedDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sortedDataGridView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sortButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.warningLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fillWithRandomButton, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.62887F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.444445F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(468, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.Location = new System.Drawing.Point(92, 397);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // unsortedDataGridView
            // 
            this.unsortedDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unsortedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unsortedDataGridView.ColumnHeadersVisible = false;
            this.unsortedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.unsortedDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unsortedDataGridView.Location = new System.Drawing.Point(3, 3);
            this.unsortedDataGridView.Name = "unsortedDataGridView";
            this.unsortedDataGridView.RowHeadersVisible = false;
            this.unsortedDataGridView.RowTemplate.Height = 25;
            this.unsortedDataGridView.Size = new System.Drawing.Size(228, 388);
            this.unsortedDataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 21;
            // 
            // sortedDataGridView
            // 
            this.sortedDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sortedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sortedDataGridView.ColumnHeadersVisible = false;
            this.sortedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.sortedDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortedDataGridView.Location = new System.Drawing.Point(237, 3);
            this.sortedDataGridView.Name = "sortedDataGridView";
            this.sortedDataGridView.RowHeadersVisible = false;
            this.sortedDataGridView.RowTemplate.Height = 25;
            this.sortedDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sortedDataGridView.Size = new System.Drawing.Size(228, 388);
            this.sortedDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 21;
            // 
            // warningLabel
            // 
            this.warningLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(237, 428);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(75, 15);
            this.warningLabel.TabIndex = 4;
            this.warningLabel.Text = "Ошибок нет";
            // 
            // fillWithRandomButton
            // 
            this.fillWithRandomButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fillWithRandomButton.Location = new System.Drawing.Point(5, 425);
            this.fillWithRandomButton.Name = "fillWithRandomButton";
            this.fillWithRandomButton.Size = new System.Drawing.Size(226, 22);
            this.fillWithRandomButton.TabIndex = 5;
            this.fillWithRandomButton.Text = "Заполнить случайными данными";
            this.fillWithRandomButton.UseVisualStyleBackColor = true;
            this.fillWithRandomButton.Click += new System.EventHandler(this.fillWithRandomButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(484, 489);
            this.Name = "Form1";
            this.Text = "Merge Sort";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unsortedDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortedDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button sortButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private DataGridView unsortedDataGridView;
        private DataGridView sortedDataGridView;
        private Label warningLabel;
        private Button fillWithRandomButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}