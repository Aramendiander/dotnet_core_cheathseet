# API Request Managing.

## Table of contents
  * [GET](#get)
    * [Query String](#query-string)
      * [Check if Request Query Contains Key (BOOL)](#check-if-request-query-contains-inputted-key-returns-boolean-value)
      * [Read the Key's value](#read-the-keys-value)


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
