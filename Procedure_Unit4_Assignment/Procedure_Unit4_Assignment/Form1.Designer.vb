<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Rushchb = New System.Windows.Forms.CheckBox()
        Me.NumSpoollbl = New System.Windows.Forms.Label()
        Me.NumOfSpooltxt = New System.Windows.Forms.TextBox()
        Me.Ordergrb = New System.Windows.Forms.GroupBox()
        Me.Deliverygrb = New System.Windows.Forms.GroupBox()
        Me.TotalDuelbl = New System.Windows.Forms.Label()
        Me.ShipHandellinglbl = New System.Windows.Forms.Label()
        Me.BackOrderlbl = New System.Windows.Forms.Label()
        Me.ReadyToShiplbl = New System.Windows.Forms.Label()
        Me.Calculatebtn = New System.Windows.Forms.Button()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.SpoolReadylbl = New System.Windows.Forms.Label()
        Me.SpoolBacklbl = New System.Windows.Forms.Label()
        Me.Shippinglbl = New System.Windows.Forms.Label()
        Me.Totallbl = New System.Windows.Forms.Label()
        Me.Ordergrb.SuspendLayout()
        Me.Deliverygrb.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rushchb
        '
        Me.Rushchb.AutoSize = True
        Me.Rushchb.Location = New System.Drawing.Point(55, 101)
        Me.Rushchb.Name = "Rushchb"
        Me.Rushchb.Size = New System.Drawing.Size(118, 21)
        Me.Rushchb.TabIndex = 0
        Me.Rushchb.Text = "Rush Delivery"
        Me.Rushchb.UseVisualStyleBackColor = True
        '
        'NumSpoollbl
        '
        Me.NumSpoollbl.AutoSize = True
        Me.NumSpoollbl.Location = New System.Drawing.Point(9, 53)
        Me.NumSpoollbl.Name = "NumSpoollbl"
        Me.NumSpoollbl.Size = New System.Drawing.Size(178, 17)
        Me.NumSpoollbl.TabIndex = 1
        Me.NumSpoollbl.Text = "Number of Spools Ordered"
        '
        'NumOfSpooltxt
        '
        Me.NumOfSpooltxt.Location = New System.Drawing.Point(210, 50)
        Me.NumOfSpooltxt.Name = "NumOfSpooltxt"
        Me.NumOfSpooltxt.Size = New System.Drawing.Size(143, 22)
        Me.NumOfSpooltxt.TabIndex = 2
        '
        'Ordergrb
        '
        Me.Ordergrb.Controls.Add(Me.Rushchb)
        Me.Ordergrb.Controls.Add(Me.NumOfSpooltxt)
        Me.Ordergrb.Controls.Add(Me.NumSpoollbl)
        Me.Ordergrb.Location = New System.Drawing.Point(12, 11)
        Me.Ordergrb.Name = "Ordergrb"
        Me.Ordergrb.Size = New System.Drawing.Size(388, 160)
        Me.Ordergrb.TabIndex = 3
        Me.Ordergrb.TabStop = False
        Me.Ordergrb.Text = "Order Information"
        '
        'Deliverygrb
        '
        Me.Deliverygrb.Controls.Add(Me.Totallbl)
        Me.Deliverygrb.Controls.Add(Me.Shippinglbl)
        Me.Deliverygrb.Controls.Add(Me.SpoolBacklbl)
        Me.Deliverygrb.Controls.Add(Me.SpoolReadylbl)
        Me.Deliverygrb.Controls.Add(Me.TotalDuelbl)
        Me.Deliverygrb.Controls.Add(Me.ShipHandellinglbl)
        Me.Deliverygrb.Controls.Add(Me.BackOrderlbl)
        Me.Deliverygrb.Controls.Add(Me.ReadyToShiplbl)
        Me.Deliverygrb.Location = New System.Drawing.Point(19, 193)
        Me.Deliverygrb.Name = "Deliverygrb"
        Me.Deliverygrb.Size = New System.Drawing.Size(380, 226)
        Me.Deliverygrb.TabIndex = 4
        Me.Deliverygrb.TabStop = False
        Me.Deliverygrb.Text = "Delivery Information"
        '
        'TotalDuelbl
        '
        Me.TotalDuelbl.AutoSize = True
        Me.TotalDuelbl.Location = New System.Drawing.Point(83, 184)
        Me.TotalDuelbl.Name = "TotalDuelbl"
        Me.TotalDuelbl.Size = New System.Drawing.Size(74, 17)
        Me.TotalDuelbl.TabIndex = 7
        Me.TotalDuelbl.Text = "Total Due:"
        '
        'ShipHandellinglbl
        '
        Me.ShipHandellinglbl.AutoSize = True
        Me.ShipHandellinglbl.Location = New System.Drawing.Point(31, 132)
        Me.ShipHandellinglbl.Name = "ShipHandellinglbl"
        Me.ShipHandellinglbl.Size = New System.Drawing.Size(135, 17)
        Me.ShipHandellinglbl.TabIndex = 6
        Me.ShipHandellinglbl.Text = "Shipping & Handeling"
        '
        'BackOrderlbl
        '
        Me.BackOrderlbl.AutoSize = True
        Me.BackOrderlbl.Location = New System.Drawing.Point(24, 85)
        Me.BackOrderlbl.Name = "BackOrderlbl"
        Me.BackOrderlbl.Size = New System.Drawing.Size(144, 17)
        Me.BackOrderlbl.TabIndex = 5
        Me.BackOrderlbl.Text = "Spool on Back Order:"
        '
        'ReadyToShiplbl
        '
        Me.ReadyToShiplbl.AutoSize = True
        Me.ReadyToShiplbl.Location = New System.Drawing.Point(24, 33)
        Me.ReadyToShiplbl.Name = "ReadyToShiplbl"
        Me.ReadyToShiplbl.Size = New System.Drawing.Size(148, 17)
        Me.ReadyToShiplbl.TabIndex = 4
        Me.ReadyToShiplbl.Text = "Spools Ready to Ship:"
        '
        'Calculatebtn
        '
        Me.Calculatebtn.Location = New System.Drawing.Point(57, 452)
        Me.Calculatebtn.Name = "Calculatebtn"
        Me.Calculatebtn.Size = New System.Drawing.Size(119, 31)
        Me.Calculatebtn.TabIndex = 5
        Me.Calculatebtn.Text = "Calculate Total"
        Me.Calculatebtn.UseVisualStyleBackColor = True
        '
        'Clearbtn
        '
        Me.Clearbtn.Location = New System.Drawing.Point(243, 453)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(122, 29)
        Me.Clearbtn.TabIndex = 6
        Me.Clearbtn.Text = "Clear Form"
        Me.Clearbtn.UseVisualStyleBackColor = True
        '
        'Exitbtn
        '
        Me.Exitbtn.Location = New System.Drawing.Point(138, 507)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(138, 31)
        Me.Exitbtn.TabIndex = 7
        Me.Exitbtn.Text = "Exit"
        Me.Exitbtn.UseVisualStyleBackColor = True
        '
        'SpoolReadylbl
        '
        Me.SpoolReadylbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SpoolReadylbl.Location = New System.Drawing.Point(212, 34)
        Me.SpoolReadylbl.Name = "SpoolReadylbl"
        Me.SpoolReadylbl.Size = New System.Drawing.Size(122, 24)
        Me.SpoolReadylbl.TabIndex = 8
        '
        'SpoolBacklbl
        '
        Me.SpoolBacklbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SpoolBacklbl.Location = New System.Drawing.Point(212, 77)
        Me.SpoolBacklbl.Name = "SpoolBacklbl"
        Me.SpoolBacklbl.Size = New System.Drawing.Size(122, 25)
        Me.SpoolBacklbl.TabIndex = 9
        '
        'Shippinglbl
        '
        Me.Shippinglbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Shippinglbl.Location = New System.Drawing.Point(212, 124)
        Me.Shippinglbl.Name = "Shippinglbl"
        Me.Shippinglbl.Size = New System.Drawing.Size(122, 25)
        Me.Shippinglbl.TabIndex = 10
        '
        'Totallbl
        '
        Me.Totallbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Totallbl.Location = New System.Drawing.Point(212, 176)
        Me.Totallbl.Name = "Totallbl"
        Me.Totallbl.Size = New System.Drawing.Size(122, 25)
        Me.Totallbl.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 548)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.Calculatebtn)
        Me.Controls.Add(Me.Deliverygrb)
        Me.Controls.Add(Me.Ordergrb)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Status"
        Me.Ordergrb.ResumeLayout(False)
        Me.Ordergrb.PerformLayout()
        Me.Deliverygrb.ResumeLayout(False)
        Me.Deliverygrb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Rushchb As CheckBox
    Friend WithEvents NumOfSpooltxt As TextBox
    Friend WithEvents Ordergrb As GroupBox
    Friend WithEvents Deliverygrb As GroupBox
    Friend WithEvents TotalDuelbl As Label
    Friend WithEvents ShipHandellinglbl As Label
    Friend WithEvents BackOrderlbl As Label
    Friend WithEvents ReadyToShiplbl As Label
    Friend WithEvents Calculatebtn As Button
    Friend WithEvents Clearbtn As Button
    Friend WithEvents Exitbtn As Button
    Friend WithEvents NumSpoollbl As Label
    Friend WithEvents Totallbl As Label
    Friend WithEvents Shippinglbl As Label
    Friend WithEvents SpoolBacklbl As Label
    Friend WithEvents SpoolReadylbl As Label
End Class
