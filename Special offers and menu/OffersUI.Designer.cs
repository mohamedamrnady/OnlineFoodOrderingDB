using System.ComponentModel;

namespace OFODBGUI.Models;

partial class OffersUI
{
   /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        dataview = new System.Windows.Forms.DataGridView();
        OfferLabel = new System.Windows.Forms.Label();
        insert = new System.Windows.Forms.Button();
        update = new System.Windows.Forms.Button();
        manageItems = new System.Windows.Forms.Button();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        delete = new System.Windows.Forms.Button();
        outputbox = new System.Windows.Forms.RichTextBox();
        ((System.ComponentModel.ISupportInitialize)dataview).BeginInit();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // dataview
        // 
        dataview.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataview.Location = new System.Drawing.Point(2, 38);
        dataview.Name = "dataview";
        dataview.RowHeadersWidth = 62;
        dataview.Size = new System.Drawing.Size(1242, 267);
        dataview.TabIndex = 0;
        dataview.Text = "dataGridView1";
        // 
        // MenuLabel
        // 
        OfferLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
        OfferLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        OfferLabel.Location = new System.Drawing.Point(460, -3);
        OfferLabel.Name = "OfferLabel";
        OfferLabel.Size = new System.Drawing.Size(146, 38);
        OfferLabel.TabIndex = 1;
        OfferLabel.Text = "Offers";
        OfferLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // insert
        // 
        insert.Anchor = System.Windows.Forms.AnchorStyles.None;
        insert.Location = new System.Drawing.Point(129, 3);
        insert.Name = "insert";
        insert.Size = new System.Drawing.Size(157, 73);
        insert.TabIndex = 2;
        insert.Text = "Insert";
        insert.UseVisualStyleBackColor = true;
        insert.Click += insert_Click;
        // 
        // update
        // 
        update.Anchor = System.Windows.Forms.AnchorStyles.None;
        update.Location = new System.Drawing.Point(544, 3);
        update.Name = "update";
        update.Size = new System.Drawing.Size(157, 73);
        update.TabIndex = 3;
        update.Text = "Update";
        update.UseVisualStyleBackColor = true;
        update.Click += update_Click;
        // 
        // manageItems
        // 
        this.manageItems.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.manageItems.Location = new System.Drawing.Point(959, 3);
        this.manageItems.Name = "manageItems";
        this.manageItems.Size = new System.Drawing.Size(157, 73);
        this.manageItems.TabIndex = 5;
        this.manageItems.Text = "Manage Items";
        this.manageItems.UseVisualStyleBackColor = true;
        this.manageItems.Click += new System.EventHandler(this.manageItems_Click);
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
        tableLayoutPanel1.ColumnCount = 4;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.Controls.Add(delete, 2, 0);
        tableLayoutPanel1.Controls.Add(insert, 0, 0);
        tableLayoutPanel1.Controls.Add(update, 1, 0);
        tableLayoutPanel1.Controls.Add(this.manageItems, 3, 0);
        tableLayoutPanel1.Location = new System.Drawing.Point(2, 311);
        tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new System.Drawing.Size(1245, 79);
        tableLayoutPanel1.TabIndex = 6;
        // 
        // delete
        // 
        delete.Anchor = System.Windows.Forms.AnchorStyles.None;
        delete.Location = new System.Drawing.Point(959, 3);
        delete.Name = "delete";
        delete.Size = new System.Drawing.Size(157, 73);
        delete.TabIndex = 4;
        delete.Text = "Delete";
        delete.UseVisualStyleBackColor = true;
        delete.Click += delete_Click;
        // 
        // outputbox
        // 
        outputbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        outputbox.Location = new System.Drawing.Point(2, 468);
        outputbox.Name = "outputbox";
        outputbox.ReadOnly = true;
        outputbox.Size = new System.Drawing.Size(1242, 222);
        outputbox.TabIndex = 7;
        outputbox.Text = "";
        // 
        // OffersUI
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1256, 691);
        Controls.Add(outputbox);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(OfferLabel);
        Controls.Add(dataview);
        Text = "OffersUI";
        Load += OffersUI_Load;
        ((System.ComponentModel.ISupportInitialize)dataview).EndInit();
        tableLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.RichTextBox outputbox;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Button delete;
    private System.Windows.Forms.Button manageItems;

    private System.Windows.Forms.Button insert;
    private System.Windows.Forms.Button update;

    private System.Windows.Forms.Label OfferLabel;

    private System.Windows.Forms.DataGridView dataview;

    #endregion
}