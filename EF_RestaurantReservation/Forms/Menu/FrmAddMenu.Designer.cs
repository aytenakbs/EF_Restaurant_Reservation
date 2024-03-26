namespace EF_RestaurantReservation.Forms.Menu;

partial class FrmAddMenu
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
        dtGridMenuList = new DataGridView();
        btnAdd = new Button();
        label1 = new Label();
        txtTitle = new TextBox();
        label2 = new Label();
        txtDescription = new TextBox();
        label3 = new Label();
        txtPrice = new TextBox();
        lblMenu = new Label();
        ((System.ComponentModel.ISupportInitialize)dtGridMenuList).BeginInit();
        SuspendLayout();
        // 
        // dtGridMenuList
        // 
        dtGridMenuList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtGridMenuList.Location = new Point(622, 77);
        dtGridMenuList.Margin = new Padding(4);
        dtGridMenuList.Name = "dtGridMenuList";
        dtGridMenuList.RowHeadersWidth = 51;
        dtGridMenuList.Size = new Size(609, 458);
        dtGridMenuList.TabIndex = 0;
        dtGridMenuList.CellClick += dtGridMenuList_CellClick;
        
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(401, 180);
        btnAdd.Margin = new Padding(4);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(168, 36);
        btnAdd.TabIndex = 1;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(37, 48);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(48, 25);
        label1.TabIndex = 2;
        label1.Text = "Title:";
        // 
        // txtTitle
        // 
        txtTitle.Location = new Point(187, 42);
        txtTitle.Margin = new Padding(4);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(382, 31);
        txtTitle.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(37, 87);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(106, 25);
        label2.TabIndex = 2;
        label2.Text = "Description:";
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(187, 81);
        txtDescription.Margin = new Padding(4);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(382, 31);
        txtDescription.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(37, 126);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(53, 25);
        label3.TabIndex = 2;
        label3.Text = "Price:";
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(187, 120);
        txtPrice.Margin = new Padding(4);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(382, 31);
        txtPrice.TabIndex = 3;
        // 
        // lblMenu
        // 
        lblMenu.AutoSize = true;
        lblMenu.Location = new Point(622, 38);
        lblMenu.Margin = new Padding(4, 0, 4, 0);
        lblMenu.Name = "lblMenu";
        lblMenu.Size = new Size(57, 25);
        lblMenu.TabIndex = 2;
        lblMenu.Text = "Menu";
        // 
        // FrmAddMenu
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1254, 548);
        Controls.Add(txtPrice);
        Controls.Add(label3);
        Controls.Add(txtDescription);
        Controls.Add(label2);
        Controls.Add(txtTitle);
        Controls.Add(lblMenu);
        Controls.Add(label1);
        Controls.Add(btnAdd);
        Controls.Add(dtGridMenuList);
        Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "FrmAddMenu";
        Text = "FrmAddMenu";
        Load += FrmAddMenu_Load;
        ((System.ComponentModel.ISupportInitialize)dtGridMenuList).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dtGridMenuList;
    private Button btnAdd;
    private Label label1;
    private TextBox txtTitle;
    private Label label2;
    private TextBox txtDescription;
    private Label label3;
    private TextBox txtPrice;
    private Label lblMenu;
}