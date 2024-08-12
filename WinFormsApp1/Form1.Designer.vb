<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        lblLogmasuk = New Label()
        lblIdpengguna = New Label()
        lblKatalaluan = New Label()
        BtnLogin = New Button()
        txtIdpengguna = New TextBox()
        txtKatalaluan = New TextBox()
        SuspendLayout()
        ' 
        ' lblLogmasuk
        ' 
        lblLogmasuk.AutoSize = True
        lblLogmasuk.Location = New Point(106, 25)
        lblLogmasuk.Name = "lblLogmasuk"
        lblLogmasuk.Size = New Size(90, 20)
        lblLogmasuk.TabIndex = 0
        lblLogmasuk.Text = "LOG MASUK"
        ' 
        ' lblIdpengguna
        ' 
        lblIdpengguna.AutoSize = True
        lblIdpengguna.Location = New Point(22, 82)
        lblIdpengguna.Name = "lblIdpengguna"
        lblIdpengguna.Size = New Size(93, 20)
        lblIdpengguna.TabIndex = 1
        lblIdpengguna.Text = "ID Pengguna"
        ' 
        ' lblKatalaluan
        ' 
        lblKatalaluan.AutoSize = True
        lblKatalaluan.Location = New Point(22, 130)
        lblKatalaluan.Name = "lblKatalaluan"
        lblKatalaluan.Size = New Size(86, 20)
        lblKatalaluan.TabIndex = 2
        lblKatalaluan.Text = "Kata Laluan"
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(106, 194)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(114, 29)
        BtnLogin.TabIndex = 3
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtIdpengguna
        ' 
        txtIdpengguna.Location = New Point(129, 75)
        txtIdpengguna.Name = "txtIdpengguna"
        txtIdpengguna.Size = New Size(182, 27)
        txtIdpengguna.TabIndex = 4
        ' 
        ' txtKatalaluan
        ' 
        txtKatalaluan.Location = New Point(129, 127)
        txtKatalaluan.Name = "txtKatalaluan"
        txtKatalaluan.Size = New Size(182, 27)
        txtKatalaluan.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(332, 253)
        Controls.Add(txtKatalaluan)
        Controls.Add(txtIdpengguna)
        Controls.Add(BtnLogin)
        Controls.Add(lblKatalaluan)
        Controls.Add(lblIdpengguna)
        Controls.Add(lblLogmasuk)
        Name = "Form1"
        Text = "Login Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLogmasuk As Label
    Friend WithEvents lblIdpengguna As Label
    Friend WithEvents lblKatalaluan As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents txtIdpengguna As TextBox
    Friend WithEvents txtKatalaluan As TextBox

End Class
