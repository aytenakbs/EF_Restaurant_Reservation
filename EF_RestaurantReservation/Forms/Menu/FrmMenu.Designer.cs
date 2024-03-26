namespace EF_RestaurantReservation.Forms.Menu;

partial class FrmMenu
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
        txtPrice = new TextBox();
        label3 = new Label();
        txtDescription = new TextBox();
        label2 = new Label();
        txtTitle = new TextBox();
        lblMenu = new Label();
        label1 = new Label();
        btnDelete = new Button();
        dtGridMenuList = new DataGridView();
        btnUpdate = new Button();
        ((System.ComponentModel.ISupportInitialize)dtGridMenuList).BeginInit();
        SuspendLayout();
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(176, 138);
        txtPrice.Margin = new Padding(4);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(403, 31);
        txtPrice.TabIndex = 10;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(26, 144);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(53, 25);
        label3.TabIndex = 6;
        label3.Text = "Price:";
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(176, 99);
        txtDescription.Margin = new Padding(4);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(403, 31);
        txtDescription.TabIndex = 11;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(26, 105);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(106, 25);
        label2.TabIndex = 7;
        label2.Text = "Description:";
        // 
        // txtTitle
        // 
        txtTitle.Location = new Point(176, 60);
        txtTitle.Margin = new Padding(4);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(403, 31);
        txtTitle.TabIndex = 12;
        // 
        // lblMenu
        // 
        lblMenu.AutoSize = true;
        lblMenu.Location = new Point(608, 21);
        lblMenu.Margin = new Padding(4, 0, 4, 0);
        lblMenu.Name = "lblMenu";
        lblMenu.Size = new Size(57, 25);
        lblMenu.TabIndex = 8;
        lblMenu.Text = "Menu";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(26, 66);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(48, 25);
        label1.TabIndex = 9;
        label1.Text = "Title:";
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(176, 197);
        btnDelete.Margin = new Padding(4);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(189, 36);
        btnDelete.TabIndex = 5;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // dtGridMenuList
        // 
        dtGridMenuList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtGridMenuList.Location = new Point(608, 60);
        dtGridMenuList.Margin = new Padding(4);
        dtGridMenuList.Name = "dtGridMenuList";
        dtGridMenuList.RowHeadersWidth = 51;
        dtGridMenuList.Size = new Size(669, 458);
        dtGridMenuList.TabIndex = 4;
        dtGridMenuList.CellClick += dtGridMenuList_CellClick;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(390, 197);
        btnUpdate.Margin = new Padding(4);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(189, 36);
        btnUpdate.TabIndex = 5;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // FrmMenu
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1290, 529);
        Controls.Add(txtPrice);
        Controls.Add(label3);
        Controls.Add(txtDescription);
        Controls.Add(label2);
        Controls.Add(txtTitle);
        Controls.Add(lblMenu);
        Controls.Add(label1);
        Controls.Add(btnUpdate);
        Controls.Add(btnDelete);
        Controls.Add(dtGridMenuList);
        Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "FrmMenu";
        Text = "FrmMenu";
        Load += FrmMenu_Load;
        ((System.ComponentModel.ISupportInitialize)dtGridMenuList).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtPrice;
    private Label label3;
    private TextBox txtDescription;
    private Label label2;
    private TextBox txtTitle;
    private Label lblMenu;
    private Label label1;
    private Button btnDelete;
    private DataGridView dtGridMenuList;
    private Button btnUpdate;
}