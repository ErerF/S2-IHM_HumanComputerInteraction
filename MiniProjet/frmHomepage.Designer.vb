<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblShopping = New System.Windows.Forms.Label()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.btnSupermarket = New System.Windows.Forms.Button()
        Me.btnMyAccount = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblShopping
        '
        Me.lblShopping.AutoSize = True
        Me.lblShopping.Font = New System.Drawing.Font("宋体", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblShopping.Location = New System.Drawing.Point(116, 59)
        Me.lblShopping.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblShopping.Name = "lblShopping"
        Me.lblShopping.Size = New System.Drawing.Size(157, 29)
        Me.lblShopping.TabIndex = 0
        Me.lblShopping.Text = "Shopping!"
        '
        'btnScan
        '
        Me.btnScan.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnScan.Image = Global.MiniProjet.My.Resources.Resources.Barcode_small
        Me.btnScan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnScan.Location = New System.Drawing.Point(67, 299)
        Me.btnScan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(114, 151)
        Me.btnScan.TabIndex = 4
        Me.btnScan.Text = "Scan"
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'btnSupermarket
        '
        Me.btnSupermarket.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSupermarket.Image = Global.MiniProjet.My.Resources.Resources.Shopping_Cart
        Me.btnSupermarket.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSupermarket.Location = New System.Drawing.Point(191, 141)
        Me.btnSupermarket.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSupermarket.Name = "btnSupermarket"
        Me.btnSupermarket.Size = New System.Drawing.Size(112, 151)
        Me.btnSupermarket.TabIndex = 3
        Me.btnSupermarket.Text = "Supermarket"
        Me.btnSupermarket.UseVisualStyleBackColor = True
        '
        'btnMyAccount
        '
        Me.btnMyAccount.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnMyAccount.Image = Global.MiniProjet.My.Resources.Resources.User_big
        Me.btnMyAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMyAccount.Location = New System.Drawing.Point(189, 299)
        Me.btnMyAccount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnMyAccount.Name = "btnMyAccount"
        Me.btnMyAccount.Size = New System.Drawing.Size(114, 151)
        Me.btnMyAccount.TabIndex = 2
        Me.btnMyAccount.Text = "My Account"
        Me.btnMyAccount.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnList.Image = Global.MiniProjet.My.Resources.Resources.List
        Me.btnList.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnList.Location = New System.Drawing.Point(67, 141)
        Me.btnList.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(112, 151)
        Me.btnList.TabIndex = 5
        Me.btnList.Text = "List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'frmHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 571)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.btnSupermarket)
        Me.Controls.Add(Me.btnMyAccount)
        Me.Controls.Add(Me.lblShopping)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmHomepage"
        Me.Text = "Welcome!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblShopping As Label
    Friend WithEvents btnMyAccount As Button
    Friend WithEvents btnSupermarket As Button
    Friend WithEvents btnScan As Button
    Friend WithEvents btnList As Button
End Class
