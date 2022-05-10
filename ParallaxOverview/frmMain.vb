Public Class frmMain

    Dim myContext As New BufferedGraphicsContext
    Dim myBuff As System.Drawing.BufferedGraphics

    Structure CamStruct
        Dim name As String
        Dim cc As Double
        Dim llx As Double
        Dim lly As Double
        Dim urx As Double
        Dim ury As Double
        Dim pixsize As Double
    End Structure

    Structure Point
        Dim x As Double
        Dim y As Double
    End Structure


    Structure ParallaxModelStruct
        Dim up_line As String
        Dim img1 As String
        Dim img2 As String
        Dim im1crd() As Point
        Dim im2crd() As Point
        Dim ncrd As Integer
        Dim plx() As Double
    End Structure

    Private Models(10) As ParallaxModelStruct
    Private NumModels As Integer

    Private Sub txtFileName_DragDrop(sender As Object, e As DragEventArgs) Handles txtFileName.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            txtFileName.Text = CType(e.Data.GetData(DataFormats.FileDrop), String())(0)

            'start reading and interpreting
            ReadAndInterpretFile()
        End If
    End Sub

    Private Sub txtFileName_DragEnter(sender As Object, e As DragEventArgs) Handles txtFileName.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub ReadAndInterpretFile()
        'clear all lists
        lstCamera.Items.Clear()
        lstModel.Items.Clear()

        'load cameras
        LoadCameras()

        'Parse inputfile
        ParseInputParallaxFile()

        'populate listbox with model
        PopulateModelBox()
    End Sub

    Private Sub ParseInputParallaxFile()
        Dim curModel As New ParallaxModelStruct
        'read file and expect at least 1 model!
        Dim lines() As String = System.IO.File.ReadAllLines(txtFileName.Text)
        Dim slines() As String
        Dim img As String = ""
        Dim nCrd As Integer = 0
        ReDim curModel.im1crd(25)
        ReDim curModel.im2crd(25)
        ReDim curModel.plx(25)

        'skip first!
        NumModels = -1
        For i = 1 To lines.Length() - 1
            slines = lines(i).Split(",")
            If img <> slines(0) Then
                'new model!
                img = slines(0)
                If NumModels >= 0 Then
                    'first model
                    curModel.ncrd = nCrd + 1
                    Models(NumModels) = curModel
                    NumModels += 1
                    nCrd = 0
                Else
                    NumModels += 1
                End If
                With curModel
                    .img1 = slines(0)
                    .img2 = slines(1)
                    .plx(nCrd) = CDbl(Val(slines(9)))
                    .im1crd(nCrd).x = CDbl(Val(slines(2)))
                    .im1crd(nCrd).y = CDbl(Val(slines(3)))
                    .im2crd(nCrd).x = CDbl(Val(slines(4)))
                    .im2crd(nCrd).y = CDbl(Val(slines(5)))
                End With


            Else
                'add to current model
                nCrd += 1
                With curModel
                    .plx(nCrd) = CDbl(Val(slines(9)))
                    .im1crd(nCrd).x = CDbl(Val(slines(2)))
                    .im1crd(nCrd).y = CDbl(Val(slines(3)))
                    .im2crd(nCrd).x = CDbl(Val(slines(4)))
                    .im2crd(nCrd).y = CDbl(Val(slines(5)))
                End With
            End If
        Next
        curModel.ncrd = nCrd + 1
        Models(NumModels) = curModel
        NumModels += 1

    End Sub

    Private Sub PopulateModelBox()
        lstModel.Items.Clear()
        For i = 0 To NumModels - 1
            lstModel.Items.Add(Models(i).img1 + " / " + Models(i).img2)
        Next
        lstModel.SelectedIndex = 0
    End Sub

    Private Sub LoadCameras()
        Dim cams As CamStruct() = GetCameras()
        For i = 0 To cams.Length() - 1
            lstCamera.Items.Add(cams(i).name)
        Next i
        lstCamera.SelectedIndex = 0
    End Sub

    Private Function GetCameras() As CamStruct()
        Dim cams(3) As CamStruct
        With cams(0)
            .name = "UCE M1 100mm"
            .pixsize = 5.2
            .llx = -34.008
            .lly = -52.026
            .urx = 34.008
            .ury = 52.026
            .cc = 100.5
        End With

        With cams(1)
            .name = "UCE M3 100mm"
            .pixsize = 4.0
            .llx = -34.008
            .lly = -52.92
            .urx = 34.008
            .ury = 52.92
            .cc = 100.5
        End With

        With cams(2)
            .name = "UCE M3 210mm"
            .pixsize = 4.0
            .llx = -34.008
            .lly = -52.92
            .urx = 34.008
            .ury = 52.92
            .cc = 212.1
        End With

        With cams(3)
            .name = "UC Xp 100mm"
            .pixsize = 6.0
            .llx = -33.93
            .lly = -51.93
            .urx = 33.93
            .ury = 51.93
            .cc = 100.5
        End With

        Return cams
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub lstModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstModel.SelectedIndexChanged
        'get info on selected model and immediately plot
        Dim curModel As ParallaxModelStruct = Models(lstModel.SelectedIndex)
        DrawOutlines(curModel)
    End Sub

    Private Sub DrawOutlines(curModel As ParallaxModelStruct)
        Dim rt As Rectangle
        myBuff = myContext.Allocate(pbMain.CreateGraphics, rt)

    End Sub
End Class
