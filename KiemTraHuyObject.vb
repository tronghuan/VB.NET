    ' ブロックの外で変数を宣言する
    Dim cForm1 As Form1

    ' cForm1 が破棄されることを保証するために Try ～ Finally を使用する
    Try
        cForm1 = New Form1()
        cForm1.ShowDialog()
    Finally
        ' cForm1 を破棄する
        If Not cForm1 Is Nothing Then
            cForm1.Dispose()
        End If
    End Try
    
    ' ブロックの外で変数を宣言する
    Dim cSqlConnection As System.Data.SqlClient.SqlConnection

    ' cSqlConnection が破棄されることを保証するために Try ～ Finally を使用する
    Try
        cSqlConnection = New System.Data.SqlClient.SqlConnection("...省略...")
        cSqlConnection.Open()

        ' cSqlConnection が閉じられることを保証するために Try ～ Finally を使用する
        Try
            '
            ' ここで cSqlConnection を使用する
            '
        Finally
            ' cSqlConnection を閉じる
            If Not cSqlConnection Is Nothing Then
                cSqlConnection.Close()
            End If
        End Try
    Finally
        ' cSqlConnection を破棄する
        If Not cSqlConnection Is Nothing Then
            cSqlConnection.Dispose()
        End If
    End Try
    
    ' ブロックの外で変数を宣言する
    Dim cReader As System.IO.StreamReader

    ' cReader が破棄されることを保証するために Try ～ Finally を使用する
    Try
        cReader = New System.IO.StreamReader("C:\Hoge.txt", System.Text.Encoding.Default)

        ' cReader が閉じられることを保証するために Try ～ Finally を使用する
        Try
            '
            ' ここで cReader を使用する
            '
        Finally
            ' cReader を閉じる
            If Not cReader Is Nothing Then
                cReader.Close()
            End If
        End Try
    Finally
        ' cReader を破棄する
        If Not cReader Is Nothing Then
            ' Dispose メソッドが隠蔽化されているため IDisposable から呼び出す
            Dim cDisposable As IDisposable = cReader
            cDisposable.Dispose()
        End If
    End Try
