# Api Response in C#
## Custom Api Response in C#

---
You can use this class to personalize the results of your APIs and display the results with a fixed format.


## Use :

Package required for use:

```sh
"Microsoft.AspNetCore.Mvc.Core" Version="2.2.5"
```
Add using:

```sh
using static ApiResponse;
```

## in Code

Success()
```sh
return Success();
return Success("Custom Message");
return Success(data: new { }); // Return Data
return Success("Custom Message", new { });
```
NotFound()
```sh
return NotFound();
return NotFound("Custom Message");
```
Filed()
```sh
return Filed("Custom Message");
return Filed("Custom Message", 000); // Defult is 400
```
ServerError()
```sh
return ServerError();
return ServerError("Custom Message");
```

#### Returns


```sh
 {
   "statusCode" : 000 ( http status code ),
   "isSuccess" : true/false,
   "message" : "string",
   "data" : null ( response data )
 }
```
