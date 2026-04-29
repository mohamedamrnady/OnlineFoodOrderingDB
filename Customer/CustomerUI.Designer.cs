namespace OFODBGUI.Customer
{
    partial class CustomerUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataview = new DataGridView();
            insert = new Button();
            update = new Button();
            delete = new Button();
            BackBtn = new Button();
            outputbox = new RichTextBox();
            titleLabel = new Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();

            ((System.ComponentModel.ISupportInitialize)dataview).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();

            // dataview
            dataview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            dataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataview.Location = new Point(2, 38);
            dataview.Name = "dataview";
            dataview.RowHeadersWidth = 62;
            dataview.Size = new Size(1242, 267);
            dataview.TabIndex = 0;

            // titleLabel
            titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            titleLabel.Location = new System.Drawing.Point(460, -3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(146, 38);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Customers";
            titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // insert
            insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            insert.Location = new Point(80, 3);
            insert.Name = "insert";
            insert.Size = new Size(157, 73);
            insert.TabIndex = 2;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;

            // update
            update.Anchor = System.Windows.Forms.AnchorStyles.None;
            update.Location = new Point(397, 3);
            update.Name = "update";
            update.Size = new Size(157, 73);
            update.TabIndex = 3;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;

            // tableLayoutPanel1
            tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            tableLayoutPanel1.Controls.Add(delete, 2, 0);
            tableLayoutPanel1.Controls.Add(insert, 0, 0);
            tableLayoutPanel1.Controls.Add(update, 1, 0);
            tableLayoutPanel1.Controls.Add(BackBtn, 3, 0);
            tableLayoutPanel1.Location = new Point(2, 311);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1245, 79);
            tableLayoutPanel1.TabIndex = 6;

            // delete
            delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            delete.Location = new Point(714, 3);
            delete.Name = "delete";
            delete.Size = new Size(157, 73);
            delete.TabIndex = 4;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;

            // outputbox
            outputbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            outputbox.Location = new Point(2, 468);
            outputbox.Name = "outputbox";
            outputbox.ReadOnly = true;
            outputbox.Size = new Size(1242, 222);
            outputbox.TabIndex = 7;
            outputbox.Text = "";

            // BackBtn
            BackBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            BackBtn.Location = new Point(1019, 3);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(157, 73);
            BackBtn.TabIndex = 10;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;

            // CustomerUI
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 691);
            Controls.Add(outputbox);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(titleLabel);
            Controls.Add(dataview);
            Name = "CustomerUI";
            Text = "Customers";
            Load += CustomerUI_Load;

            ((System.ComponentModel.ISupportInitialize)dataview).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataview;
        private Button insert;
        private Button update;
        private Button delete;
        private Button BackBtn;
        private RichTextBox outputbox;
        private Label titleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}