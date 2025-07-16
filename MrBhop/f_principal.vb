Option Strict On
Option Infer Off

Imports System.Threading
Imports Memory
Imports System.Runtime.InteropServices

Public Class f_principal
    Private Shared ReadOnly Memory As New Mem()
    Private Shared ReadOnly Jump As String = "client.dll+0x757DF0"
    Private Shared ReadOnly Air As String = "client.dll+0x6E1008"

    Private processId As Integer = 0
    Private bhopEnabled As Boolean = False
    Private bhopThread As Thread
    Private Delegate Sub BhopDelegate()

    <DllImport("user32.dll")>
    Private Shared Function GetAsyncKeyState(vKey As Integer) As Short
    End Function

    Private Sub Bhop()
        While bhopEnabled AndAlso cbx_act.Checked
            If GetAsyncKeyState(Keys.F7) < 0 Then
                bhopEnabled = False
                Exit While
            End If
            If cbx_act.Checked AndAlso GetAsyncKeyState(Keys.Space) < 0 Then
                Dim resultado As Integer = Memory.ReadInt(Air)
                If resultado = 0 Then
                    Memory.WriteMemory(Jump, "int", "5")
                    Thread.Sleep(35)
                    Memory.WriteMemory(Jump, "int", "4")
                End If
            End If
            Thread.Sleep(1)
        End While
    End Sub

    Private Sub StartBhopThread()
        If bhopThread Is Nothing OrElse Not bhopThread.IsAlive Then
            bhopEnabled = True
            bhopThread = New Thread(AddressOf Bhop) With {.IsBackground = True}
            bhopThread.Start()
        End If
    End Sub

    Private Sub StopBhopThread()
        bhopEnabled = False
        If bhopThread IsNot Nothing AndAlso bhopThread.IsAlive Then
            bhopThread.Join(100)
        End If
    End Sub

    Private Sub cbx_act_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_act.CheckedChanged
        If cbx_act.Checked Then
            processId = Memory.GetProcIdFromName("left4dead2")
            If processId > 0 Then
                Memory.OpenProcess(processId)
                StartBhopThread()
            Else
                cbx_act.Checked = False
            End If
        Else
            StopBhopThread()
        End If
    End Sub

#Region "formulario"
    Private Sub lb_min_Click(sender As Object, e As EventArgs) Handles lb_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lb_close_Click(sender As Object, e As EventArgs) Handles lb_close.Click
        StopBhopThread()
        Me.Close()
    End Sub


    ' moving from title bar
    Private mouseOffset As Point
    Private Sub pl_title_MouseDown(sender As Object, e As MouseEventArgs) Handles pl_title.MouseDown, PictureBox1.MouseDown, lb_titulo.MouseDown
        Dim control As Control = CType(sender, Control)
        mouseOffset = control.PointToScreen(New Point(e.X, e.Y))
        mouseOffset.X -= Me.Location.X
        mouseOffset.Y -= Me.Location.Y
    End Sub
    Private Sub pl_title_MouseMove(sender As Object, e As MouseEventArgs) Handles pl_title.MouseMove, PictureBox1.MouseMove, lb_titulo.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim newLocation As Point = Control.MousePosition
            newLocation.X -= mouseOffset.X
            newLocation.Y -= mouseOffset.Y
            Me.Location = newLocation
        End If
    End Sub

    ' I just was testing runtime control creation 
    Private Sub lb_settings_Click(sender As Object, e As EventArgs) Handles lb_settings.Click
        Dim formSize As New Size(160, 160)
        Dim fontColor As Color = Color.White
        Dim fontStyle As New Font(Me.cbx_act.Font.FontFamily, 10, Me.cbx_act.Font.Style)

        Dim form As New Form With {
            .Size = formSize,
            .MaximumSize = formSize,
            .MinimumSize = formSize,
            .BackColor = Me.BackColor,
            .FormBorderStyle = FormBorderStyle.FixedToolWindow,
            .StartPosition = FormStartPosition.CenterScreen,
            .TopMost = True,
            .Text = "Configuration"
        }

        Dim lb_act As New Label With {
            .Text = "Activate Bhop",
            .ForeColor = fontColor,
            .Font = fontStyle,
            .Location = New Point(14, 10)
        }
        form.Controls.Add(lb_act)

        Dim lb_deact As New Label With {
            .Text = "Deactivate Bhop",
            .ForeColor = fontColor,
            .Font = fontStyle,
            .Location = New Point(14, 64)
        }
        form.Controls.Add(lb_deact)

        Dim tb_act As New TextBox With {
            .Location = New Point(14, 36),
            .Size = New Size(50, 20),
            .Text = "F8"
        }
        form.Controls.Add(tb_act)

        Dim tb_deact As New TextBox With {
            .Location = New Point(14, 90),
            .Size = New Size(50, 20),
            .Text = "F7"
        }
        form.Controls.Add(tb_deact)

        form.ShowDialog()
    End Sub
#End Region
End Class
