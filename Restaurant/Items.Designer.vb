Imports System.Data.SqlClient
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Public Class items
    Inherits System.Windows.Forms.Form
    Dim newlabel As Integer = 1
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marquez\Documents\VS projekti\Restoran\RestDb.mdf;Integrated Security=True;Connect Timeout=30")

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(items))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaAdvenceButton7 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton6 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.ResetBtn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.DeleteBtn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.EditBtn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.AddBtn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.KatN = New System.Windows.Forms.TextBox()
        Me.Kol = New System.Windows.Forms.TextBox()
        Me.Kate = New System.Windows.Forms.ComboBox()
        Me.Cij = New System.Windows.Forms.TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.ImePP = New System.Windows.Forms.TextBox()
        Me.ItemDG = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Co = New System.Windows.Forms.ComboBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.GunaAdvenceButton7)
        Me.Guna2Panel1.Controls.Add(Me.GunaAdvenceButton6)
        Me.Guna2Panel1.Controls.Add(Me.ResetBtn)
        Me.Guna2Panel1.Controls.Add(Me.DeleteBtn)
        Me.Guna2Panel1.Controls.Add(Me.EditBtn)
        Me.Guna2Panel1.Controls.Add(Me.AddBtn)
        Me.Guna2Panel1.Controls.Add(Me.GunaAdvenceButton1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(180, 620)
        Me.Guna2Panel1.TabIndex = 0
        '
        'GunaAdvenceButton7
        '
        Me.GunaAdvenceButton7.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton7.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.GunaAdvenceButton7.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton7.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GunaAdvenceButton7.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton7.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton7.CheckedImage = CType(resources.GetObject("GunaAdvenceButton7.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton7.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GunaAdvenceButton7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton7.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GunaAdvenceButton7.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton7.Image = CType(resources.GetObject("GunaAdvenceButton7.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton7.ImageOffsetX = 15
        Me.GunaAdvenceButton7.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaAdvenceButton7.LineColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.GunaAdvenceButton7.Location = New System.Drawing.Point(0, 367)
        Me.GunaAdvenceButton7.Name = "GunaAdvenceButton7"
        Me.GunaAdvenceButton7.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GunaAdvenceButton7.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton7.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton7.OnHoverImage = Nothing
        Me.GunaAdvenceButton7.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GunaAdvenceButton7.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton7.Size = New System.Drawing.Size(180, 50)
        Me.GunaAdvenceButton7.TabIndex = 7
        Me.GunaAdvenceButton7.Text = "Employees"
        '
        'GunaAdvenceButton6
        '
        Me.GunaAdvenceButton6.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton6.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.GunaAdvenceButton6.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GunaAdvenceButton6.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton6.CheckedImage = CType(resources.GetObject("GunaAdvenceButton6.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton6.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GunaAdvenceButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GunaAdvenceButton6.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton6.Image = CType(resources.GetObject("GunaAdvenceButton6.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton6.ImageOffsetX = 40
        Me.GunaAdvenceButton6.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaAdvenceButton6.LineColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.GunaAdvenceButton6.Location = New System.Drawing.Point(0, 567)
        Me.GunaAdvenceButton6.Name = "GunaAdvenceButton6"
        Me.GunaAdvenceButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GunaAdvenceButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton6.OnHoverImage = Nothing
        Me.GunaAdvenceButton6.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GunaAdvenceButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton6.Size = New System.Drawing.Size(180, 50)
        Me.GunaAdvenceButton6.TabIndex = 6
        Me.GunaAdvenceButton6.Text = "Logout"
        '
        'ResetBtn
        '
        Me.ResetBtn.AnimationHoverSpeed = 0.07!
        Me.ResetBtn.AnimationSpeed = 0.03!
        Me.ResetBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ResetBtn.BorderColor = System.Drawing.Color.Black
        Me.ResetBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ResetBtn.CheckedBorderColor = System.Drawing.Color.Black
        Me.ResetBtn.CheckedForeColor = System.Drawing.Color.White
        Me.ResetBtn.CheckedImage = CType(resources.GetObject("ResetBtn.CheckedImage"), System.Drawing.Image)
        Me.ResetBtn.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ResetBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ResetBtn.FocusedColor = System.Drawing.Color.Empty
        Me.ResetBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ResetBtn.ForeColor = System.Drawing.Color.White
        Me.ResetBtn.Image = CType(resources.GetObject("ResetBtn.Image"), System.Drawing.Image)
        Me.ResetBtn.ImageOffsetX = 15
        Me.ResetBtn.ImageSize = New System.Drawing.Size(16, 16)
        Me.ResetBtn.LineColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ResetBtn.Location = New System.Drawing.Point(0, 311)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ResetBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.ResetBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.ResetBtn.OnHoverImage = Nothing
        Me.ResetBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ResetBtn.OnPressedColor = System.Drawing.Color.Black
        Me.ResetBtn.Size = New System.Drawing.Size(180, 50)
        Me.ResetBtn.TabIndex = 5
        Me.ResetBtn.Text = "Reset"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.AnimationHoverSpeed = 0.07!
        Me.DeleteBtn.AnimationSpeed = 0.03!
        Me.DeleteBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.DeleteBtn.BorderColor = System.Drawing.Color.Black
        Me.DeleteBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.DeleteBtn.CheckedBorderColor = System.Drawing.Color.Black
        Me.DeleteBtn.CheckedForeColor = System.Drawing.Color.White
        Me.DeleteBtn.CheckedImage = CType(resources.GetObject("DeleteBtn.CheckedImage"), System.Drawing.Image)
        Me.DeleteBtn.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.DeleteBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DeleteBtn.FocusedColor = System.Drawing.Color.Empty
        Me.DeleteBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Image = CType(resources.GetObject("DeleteBtn.Image"), System.Drawing.Image)
        Me.DeleteBtn.ImageOffsetX = 15
        Me.DeleteBtn.ImageSize = New System.Drawing.Size(16, 16)
        Me.DeleteBtn.LineColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.DeleteBtn.Location = New System.Drawing.Point(1, 255)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.DeleteBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.DeleteBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.DeleteBtn.OnHoverImage = Nothing
        Me.DeleteBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.DeleteBtn.OnPressedColor = System.Drawing.Color.Black
        Me.DeleteBtn.Size = New System.Drawing.Size(180, 50)
        Me.DeleteBtn.TabIndex = 4
        Me.DeleteBtn.Text = "Delete"
        '
        'EditBtn
        '
        Me.EditBtn.AnimationHoverSpeed = 0.07!
        Me.EditBtn.AnimationSpeed = 0.03!
        Me.EditBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.EditBtn.BorderColor = System.Drawing.Color.Black
        Me.EditBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.EditBtn.CheckedBorderColor = System.Drawing.Color.Black
        Me.EditBtn.CheckedForeColor = System.Drawing.Color.White
        Me.EditBtn.CheckedImage = CType(resources.GetObject("EditBtn.CheckedImage"), System.Drawing.Image)
        Me.EditBtn.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.EditBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.EditBtn.FocusedColor = System.Drawing.Color.Empty
        Me.EditBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.EditBtn.ForeColor = System.Drawing.Color.White
        Me.EditBtn.Image = CType(resources.GetObject("EditBtn.Image"), System.Drawing.Image)
        Me.EditBtn.ImageOffsetX = 18
        Me.EditBtn.ImageSize = New System.Drawing.Size(16, 16)
        Me.EditBtn.LineColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.EditBtn.Location = New System.Drawing.Point(-3, 199)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.EditBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.EditBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.EditBtn.OnHoverImage = Nothing
        Me.EditBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.EditBtn.OnPressedColor = System.Drawing.Color.Black
        Me.EditBtn.Size = New System.Drawing.Size(180, 50)
        Me.EditBtn.TabIndex = 3
        Me.EditBtn.Text = "Edit"
        '
        'AddBtn
        '
        Me.AddBtn.AnimationHoverSpeed = 0.07!
        Me.AddBtn.AnimationSpeed = 0.03!
        Me.AddBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.AddBtn.BorderColor = System.Drawing.Color.Black
        Me.AddBtn.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.AddBtn.CheckedBorderColor = System.Drawing.Color.Black
        Me.AddBtn.CheckedForeColor = System.Drawing.Color.White
        Me.AddBtn.CheckedImage = CType(resources.GetObject("AddBtn.CheckedImage"), System.Drawing.Image)
        Me.AddBtn.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.AddBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.AddBtn.FocusedColor = System.Drawing.Color.Empty
        Me.AddBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.Image = CType(resources.GetObject("AddBtn.Image"), System.Drawing.Image)
        Me.AddBtn.ImageOffsetX = 15
        Me.AddBtn.ImageSize = New System.Drawing.Size(16, 16)
        Me.AddBtn.LineColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.AddBtn.Location = New System.Drawing.Point(0, 143)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.AddBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.AddBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.AddBtn.OnHoverImage = Nothing
        Me.AddBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.AddBtn.OnPressedColor = System.Drawing.Color.Black
        Me.AddBtn.Size = New System.Drawing.Size(180, 50)
        Me.AddBtn.TabIndex = 2
        Me.AddBtn.Text = "Add Product"
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageOffsetX = 15
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(0, 87)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(180, 50)
        Me.GunaAdvenceButton1.TabIndex = 1
        Me.GunaAdvenceButton1.Text = "Add Category"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.GunaLabel2)
        Me.Guna2Panel2.Controls.Add(Me.GunaLabel1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(180, 50)
        Me.Guna2Panel2.TabIndex = 0
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(86, 29)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(44, 17)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Admin"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(42, 9)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(139, 21)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "Restaurant Allegro"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(481, 15)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.ShadowDecoration.Parent = Me.Guna2PictureBox3
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox3.TabIndex = 1
        Me.Guna2PictureBox3.TabStop = False
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(513, 11)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(139, 21)
        Me.GunaLabel4.TabIndex = 2
        Me.GunaLabel4.Text = "Restaurant Allegro"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(532, 33)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(100, 17)
        Me.GunaLabel3.TabIndex = 3
        Me.GunaLabel3.Text = "Manage product"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.White
        Me.GunaLabel5.Location = New System.Drawing.Point(382, 113)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(89, 17)
        Me.GunaLabel5.TabIndex = 5
        Me.GunaLabel5.Text = "New category"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.White
        Me.GunaLabel6.Location = New System.Drawing.Point(418, 146)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(53, 17)
        Me.GunaLabel6.TabIndex = 7
        Me.GunaLabel6.Text = "Product"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.White
        Me.GunaLabel7.Location = New System.Drawing.Point(410, 177)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(61, 17)
        Me.GunaLabel7.TabIndex = 8
        Me.GunaLabel7.Text = "Category"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.White
        Me.GunaLabel8.Location = New System.Drawing.Point(435, 208)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(36, 17)
        Me.GunaLabel8.TabIndex = 11
        Me.GunaLabel8.Text = "Price"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.White
        Me.GunaLabel9.Location = New System.Drawing.Point(415, 239)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(56, 17)
        Me.GunaLabel9.TabIndex = 12
        Me.GunaLabel9.Text = "Quantity"
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(943, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(27, 24)
        Me.Guna2ControlBox2.TabIndex = 22
        '
        'KatN
        '
        Me.KatN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.KatN.ForeColor = System.Drawing.Color.Black
        Me.KatN.Location = New System.Drawing.Point(477, 110)
        Me.KatN.Name = "KatN"
        Me.KatN.Size = New System.Drawing.Size(187, 25)
        Me.KatN.TabIndex = 24
        '
        'Kol
        '
        Me.Kol.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Kol.ForeColor = System.Drawing.Color.Black
        Me.Kol.Location = New System.Drawing.Point(477, 236)
        Me.Kol.Name = "Kol"
        Me.Kol.Size = New System.Drawing.Size(187, 25)
        Me.Kol.TabIndex = 27
        '
        'Kate
        '
        Me.Kate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Kate.ForeColor = System.Drawing.Color.Black
        Me.Kate.FormattingEnabled = True
        Me.Kate.Location = New System.Drawing.Point(477, 174)
        Me.Kate.Name = "Kate"
        Me.Kate.Size = New System.Drawing.Size(187, 25)
        Me.Kate.TabIndex = 23
        '
        'Cij
        '
        Me.Cij.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cij.ForeColor = System.Drawing.Color.Black
        Me.Cij.Location = New System.Drawing.Point(477, 205)
        Me.Cij.Name = "Cij"
        Me.Cij.Size = New System.Drawing.Size(187, 25)
        Me.Cij.TabIndex = 26
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'ImePP
        '
        Me.ImePP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ImePP.ForeColor = System.Drawing.Color.Black
        Me.ImePP.Location = New System.Drawing.Point(477, 143)
        Me.ImePP.Name = "ImePP"
        Me.ImePP.Size = New System.Drawing.Size(187, 25)
        Me.ImePP.TabIndex = 25
        '
        'ItemDG
        '
        Me.ItemDG.AllowUserToResizeColumns = False
        Me.ItemDG.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.ItemDG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ItemDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ItemDG.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ItemDG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemDG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ItemDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemDG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ItemDG.ColumnHeadersHeight = 28
        Me.ItemDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemDG.DefaultCellStyle = DataGridViewCellStyle3
        Me.ItemDG.EnableHeadersVisualStyles = False
        Me.ItemDG.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ItemDG.Location = New System.Drawing.Point(189, 311)
        Me.ItemDG.Name = "ItemDG"
        Me.ItemDG.RowHeadersVisible = False
        Me.ItemDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ItemDG.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ItemDG.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.ItemDG.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ItemDG.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.ItemDG.RowTemplate.Height = 25
        Me.ItemDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ItemDG.Size = New System.Drawing.Size(772, 298)
        Me.ItemDG.TabIndex = 28
        Me.ItemDG.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.ItemDG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.ItemDG.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.ItemDG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.ItemDG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.ItemDG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.ItemDG.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ItemDG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ItemDG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ItemDG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ItemDG.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ItemDG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ItemDG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ItemDG.ThemeStyle.HeaderStyle.Height = 28
        Me.ItemDG.ThemeStyle.ReadOnly = False
        Me.ItemDG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.ItemDG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ItemDG.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ItemDG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ItemDG.ThemeStyle.RowsStyle.Height = 25
        Me.ItemDG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemDG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Co
        '
        Me.Co.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Co.ForeColor = System.Drawing.Color.Black
        Me.Co.FormattingEnabled = True
        Me.Co.Location = New System.Drawing.Point(692, 174)
        Me.Co.Name = "Co"
        Me.Co.Size = New System.Drawing.Size(187, 25)
        Me.Co.TabIndex = 29
        '
        'items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 620)
        Me.Controls.Add(Me.Co)
        Me.Controls.Add(Me.ItemDG)
        Me.Controls.Add(Me.Kol)
        Me.Controls.Add(Me.Cij)
        Me.Controls.Add(Me.ImePP)
        Me.Controls.Add(Me.KatN)
        Me.Controls.Add(Me.Kate)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.Guna2PictureBox3)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents AddBtn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents EditBtn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents ResetBtn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents DeleteBtn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton6 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox

    Private Sub GunaAdvenceButton6_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton6.Click
        Dim pocetna As New Login
        pocetna.Show()
        Me.Hide()
    End Sub

    Friend WithEvents GunaAdvenceButton7 As Guna.UI.WinForms.GunaAdvenceButton

    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton7.Click
        Dim mstaff As New Staff
        mstaff.Show()
        Me.Hide()
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        If KatN.Text = "" Then
            MsgBox("Error. Enter a category!")
        Else
            Con.Open()
            Dim query = "insert into CategoryTbl values ('" & KatN.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Category added!")
            addnewlabel()
            Con.Close()
            KatN.Text = ""
            FillCategory()
        End If
    End Sub
    Private Sub Reset()
        ImePP.Text = ""
        Kate.SelectedIndex = 0
        Cij.Text = ""
        Kol.Text = ""
    End Sub
    Private Sub FillCategory()
        Con.Open()
        Dim cmd = New SqlCommand("select * from CategoryTbl", Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Tbl = New DataTable()
        adapter.Fill(Tbl)
        Kate.DataSource = Tbl
        Kate.DisplayMember = "KATi"
        Kate.ValueMember = "KATi"
        Co.DataSource = Tbl
        Co.DisplayMember = "KATt"
        Co.ValueMember = "KATt"
        Con.Close()
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCategory()
        DisplayItem()
        Co.Visible = False
    End Sub
    Private Sub DisplayItem()
        Con.Open()
        Dim query = "select * from ItemsTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDG.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If Kate.SelectedIndex = -1 Or ImePP.Text = "" Or Cij.Text = "" Or Kol.Text = "" Then
            MsgBox("Error. Enter the product!")
        Else
            Con.Open()
            Dim query = "insert into ItemsTbl values ('" & ImePP.Text & "', '" & Kate.SelectedValue.ToString() & "', " & Cij.Text & ", " & Kol.Text & ",'" & Co.SelectedValue.ToString() & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Books added!")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub

    Friend WithEvents Kate As ComboBox
    Friend WithEvents KatN As TextBox
    Friend WithEvents Kol As TextBox
    Friend WithEvents Cij As TextBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse

    Dim key = 0
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MsgBox("Error. Choose a product!")
        Else
            Con.Open()
            Dim query = "delete from ItemsTbl where ID=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("The product has been deleted from the database!")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If ImePP.Text = "" Or Kate.SelectedIndex = -1 Or Cij.Text = "" Or Kol.Text = "" Then
            MsgBox("Error. Choose a product!")
        Else
            Try
                Con.Open()
                Dim query = "update ItemsTbl Set Product='" & ImePP.Text & "', Category='" & Kate.SelectedValue.ToString() & "', Price=" & Cij.Text & ", Quantity=" & Kol.Text & ", where ID=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Change successful!")
                Con.Close()
                Reset()
                DisplayItem()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Friend WithEvents ImePP As TextBox
    Friend WithEvents ItemDG As Guna.UI2.WinForms.Guna2DataGridView

    Private Sub ItemDG_CellMouseClick_1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDG.CellMouseClick
        Dim row As DataGridViewRow = ItemDG.Rows(e.RowIndex)
        ImePP.Text = row.Cells(1).Value.ToString
        Kate.SelectedValue = row.Cells(2).Value.ToString
        Cij.Text = row.Cells(3).Value.ToString
        Kol.Text = row.Cells(4).Value.ToString
        If ImePP.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Friend WithEvents Co As ComboBox
    Public Sub addnewlabel()
        If newlabel = 11 Then
            MsgBox("Ne mozete kreirati vise od 10!")
        ElseIf newlabel < 11 Then
            Dim labeln As New Label
            Me.Controls.Add(labeln)
            labeln.Top = newlabel * 50
            labeln.Left = 500
            labeln.Text = KatN.Text & Me.newlabel.ToString
            newlabel = newlabel + 1
        End If
    End Sub
End Class
