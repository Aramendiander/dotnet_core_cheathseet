# API Response Managing.


## Table of contents
  * [Status codes](#status-codes)
    


## Status codes
Response with JSON Message:

Import Text Json Namespace
```cs
using System.Text.Json
```
Set status code, and send a message as a JSON object.
```cs
context.Response.StatusCode = 401;
context.Response.ContentType = "application/json";
var result = JsonSerializer.Serialize(new { message = "Unauthorized" });
await context.Response.WriteAsync(result);
```

## Custom Header Responses
You can send your custom header responses.
Recommended this Owasp article on [Secure headers](#https://cheatsheetseries.owasp.org/cheatsheets/HTTP_Headers_Cheat_Sheet.html#server)
```cs
context.Response.Headers["MyKey"] = "My value"; //New header
context.Response.Headers["Server"] = "webserver"; //Replaces default Server response (Kestrel, IIS, Nginx... Recommended to replace for non-informative values)
```
