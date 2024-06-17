Imports System.Net.Http

Public Class Buscar
    Private Async Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        Try
            Using client As New HttpClient()
                ' URL de tu API Node.js
                Dim apiUrl As String = "http://localhost:3000/inventario"

                ' Realizar la solicitud GET
                Dim response = Await client.GetAsync(apiUrl)

                ' Verificar si la solicitud fue exitosa
                If response.IsSuccessStatusCode Then
                    Dim content = Await response.Content.ReadAsStringAsync()
                    Dim data As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.Linq.JObject.Parse(content)

                    ' Mostrar los datos en los labels
                    lblCodigo.Text = data("Codigo").ToString()
                    lbldesc.Text = data("Descripcion").ToString()
                    lblfecha.Text = data("Fecha").ToString()
                    lblest.Text = data("Estatus").ToString()
                    lblori.Text = data("Origen").ToString()

                Else
                    MessageBox.Show("Error al obtener los datos: " & response.ReasonPhrase, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la API: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class