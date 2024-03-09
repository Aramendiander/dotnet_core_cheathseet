# API Request Managing.

## GET

### Query String

#### Check if request query contains inputted key. Returns BOOLEAN value
```cs
context.Request.Query.ContainsKey("keyName"))
```

#### Read the key's value
```cs
string value = context.Request.Query["keyName"]
```
