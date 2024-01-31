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
        studentGradesLBL = New Label()
        newGradeBTN = New Button()
        newGradeTBX = New TextBox()
        gradesLBX = New ListBox()
        calculateBTN = New Button()
        outputLBL = New Label()
        SuspendLayout()
        ' 
        ' studentGradesLBL
        ' 
        studentGradesLBL.AutoSize = True
        studentGradesLBL.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        studentGradesLBL.Location = New Point(35, 32)
        studentGradesLBL.Name = "studentGradesLBL"
        studentGradesLBL.Size = New Size(165, 30)
        studentGradesLBL.TabIndex = 1
        studentGradesLBL.Text = "Student Grades"
        ' 
        ' newGradeBTN
        ' 
        newGradeBTN.BackColor = SystemColors.ButtonHighlight
        newGradeBTN.FlatStyle = FlatStyle.Popup
        newGradeBTN.Location = New Point(293, 149)
        newGradeBTN.Name = "newGradeBTN"
        newGradeBTN.Size = New Size(183, 34)
        newGradeBTN.TabIndex = 2
        newGradeBTN.Text = "Add Grade"
        newGradeBTN.UseVisualStyleBackColor = False
        ' 
        ' newGradeTBX
        ' 
        newGradeTBX.Location = New Point(345, 84)
        newGradeTBX.Name = "newGradeTBX"
        newGradeTBX.Size = New Size(84, 31)
        newGradeTBX.TabIndex = 3
        ' 
        ' gradesLBX
        ' 
        gradesLBX.FormattingEnabled = True
        gradesLBX.ItemHeight = 25
        gradesLBX.Location = New Point(35, 84)
        gradesLBX.Name = "gradesLBX"
        gradesLBX.Size = New Size(191, 304)
        gradesLBX.TabIndex = 4
        ' 
        ' calculateBTN
        ' 
        calculateBTN.BackColor = SystemColors.ButtonHighlight
        calculateBTN.FlatStyle = FlatStyle.Popup
        calculateBTN.Location = New Point(293, 229)
        calculateBTN.Name = "calculateBTN"
        calculateBTN.Size = New Size(183, 34)
        calculateBTN.TabIndex = 5
        calculateBTN.Text = "Calculate"
        calculateBTN.UseVisualStyleBackColor = False
        ' 
        ' outputLBL
        ' 
        outputLBL.AutoSize = True
        outputLBL.Location = New Point(324, 311)
        outputLBL.Name = "outputLBL"
        outputLBL.Size = New Size(63, 25)
        outputLBL.TabIndex = 6
        outputLBL.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(510, 421)
        Controls.Add(outputLBL)
        Controls.Add(calculateBTN)
        Controls.Add(gradesLBX)
        Controls.Add(newGradeTBX)
        Controls.Add(newGradeBTN)
        Controls.Add(studentGradesLBL)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents studentGradesLBL As Label
    Friend WithEvents newGradeBTN As Button
    Friend WithEvents newGradeTBX As TextBox
    Friend WithEvents gradesLBX As ListBox
    Friend WithEvents calculateBTN As Button
    Friend WithEvents outputLBL As Label

End Class
