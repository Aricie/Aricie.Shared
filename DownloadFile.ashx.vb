Imports System.Web
Imports System.Web.Services
Imports System.IO

Public Class DownloadFile
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest



        Dim fileId As Integer = context.Request.Params("fileId")
        Dim portalId As Integer = context.Request.Params("portalId")

        Dim FC As New DotNetNuke.Services.FileSystem.FileController
        Dim file As DotNetNuke.Services.FileSystem.FileInfo = FC.GetFileById(fileId, portalId)

        Dim fichier As String = file.PhysicalPath

        context.Response.ContentType = file.ContentType

        context.Response.WriteFile(fichier)

    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class