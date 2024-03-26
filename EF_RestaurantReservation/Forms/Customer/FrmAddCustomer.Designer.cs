namespace EF_RestaurantReservation.Forms.Customer;

partial class FrmAddCustomer
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
        dtCustomerList = new DataGridView();
        label1 = new Label();
        txtName = new TextBox();
        btnAdd = new Button();
        label2 = new Label();
        txtSurname = new TextBox();
        label3 = new Label();
        txtEmail = new TextBox();
        label4 = new Label();
        txtPhoneNumber = new TextBox();
        label5 = new Label();
        txtAddress = new TextBox();
        label6 = new Label();
        ((System.ComponentModel.ISupportInitialize)dtCustomerList).BeginInit();
        SuspendLayout();
        // 
        // dtCustomerList
        // 
        dtCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtCustomerList.Location = new Point(448, 59);
        dtCustomerList.Margin = new Padding(4);
        dtCustomerList.Name = "dtCustomerList";
        dtCustomerList.RowHeadersWidth = 51;
        dtCustomerList.Size = new Size(785, 306);
        dtCustomerList.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(27, 65);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(63, 25);
        label1.TabIndex = 1;
        label1.Text = "Name:";
        // 
        // txtName
        // 
        txtName.Location = new Point(164, 59);
        txtName.Margin = new Padding(4);
        txtName.Name = "txtName";
        txtName.Size = new Size(240, 31);
        txtName.TabIndex = 2;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(229, 310);
        btnAdd.Margin = new Padding(4);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(175, 31);
        btnAdd.TabIndex = 3;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += button1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(27, 114);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(86, 25);
        label2.TabIndex = 1;
        label2.Text = "Surname:";
        // 
        // txtSurname
        // 
        txtSurname.Location = new Point(164, 108);
        txtSurname.Margin = new Padding(4);
        txtSurname.Name = "txtSurname";
        txtSurname.Size = new Size(240, 31);
        txtSurname.TabIndex = 2;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(27, 164);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(58, 25);
        label3.TabIndex = 1;
        label3.Text = "Email:";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(164, 158);
        txtEmail.Margin = new Padding(4);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(240, 31);
        txtEmail.TabIndex = 2;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(27, 214);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(136, 25);
        label4.TabIndex = 1;
        label4.Text = "Phone Number:";
        // 
        // txtPhoneNumber
        // 
        txtPhoneNumber.Location = new Point(164, 208);
        txtPhoneNumber.Margin = new Padding(4);
        txtPhoneNumber.Name = "txtPhoneNumber";
        txtPhoneNumber.Size = new Size(240, 31);
        txtPhoneNumber.TabIndex = 2;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(27, 263);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(81, 25);
        label5.TabIndex = 1;
        label5.Text = "Address:";
        // 
        // txtAddress
        // 
        txtAddress.Location = new Point(164, 257);
        txtAddress.Margin = new Padding(4);
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new Size(240, 31);
        txtAddress.TabIndex = 2;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(448, 30);
        label6.Name = "label6";
        label6.Size = new Size(113, 25);
        label6.TabIndex = 4;
        label6.Text = "CUSTOMERS";
        // 
        // FrmAddCustomer
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1269, 405);
        Controls.Add(label6);
        Controls.Add(btnAdd);
        Controls.Add(txtAddress);
        Controls.Add(label5);
        Controls.Add(txtPhoneNumber);
        Controls.Add(label4);
        Controls.Add(txtEmail);
        Controls.Add(label3);
        Controls.Add(txtSurname);
        Controls.Add(label2);
        Controls.Add(txtName);
        Controls.Add(label1);
        Controls.Add(dtCustomerList);
        Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "FrmAddCustomer";
        Text = "FrmAddCustomer";
        ((System.ComponentModel.ISupportInitialize)dtCustomerList).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dtCustomerList;
    private Label label1;
    private TextBox txtName;
    private Button btnAdd;
    private Label label2;
    private TextBox txtSurname;
    private Label label3;
    private TextBox txtEmail;
    private Label label4;
    private TextBox txtPhoneNumber;
    private Label label5;
    private TextBox txtAddress;
    private Label label6;
}