<!DOCTYPE HTML>
<html>
<head>
    <title>@ViewBag.Title</title>
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
    <script src="@Url.Content("~/Scripts/MicrosoftAjax.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/MicrosoftMvcValidation.js")" type="text/javascript"></script>
    
    @Html.DevExpress().GetStyleSheets(New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout}, New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors}, New StyleSheet With {.ExtensionSuite = ExtensionSuite.HtmlEditor}, New StyleSheet With {.ExtensionSuite = ExtensionSuite.GridView}, New StyleSheet With {.ExtensionSuite = ExtensionSuite.PivotGrid}, New StyleSheet With {.ExtensionSuite = ExtensionSuite.Chart}, New StyleSheet With {.ExtensionSuite = ExtensionSuite.Report})
    @Html.DevExpress().GetScripts(New Script With {.ExtensionSuite = ExtensionSuite.GridView}, New Script With {.ExtensionSuite = ExtensionSuite.PivotGrid}, New Script With {.ExtensionSuite = ExtensionSuite.HtmlEditor}, New Script With {.ExtensionSuite = ExtensionSuite.Editors}, New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout}, New Script With {.ExtensionSuite = ExtensionSuite.Chart}, New Script With {.ExtensionSuite = ExtensionSuite.Report})
</head>
<body>
    @RenderBody()
</body>
</html>