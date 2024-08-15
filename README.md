# Objective
How to add a Custom Header to All Responses

# Steps

## 1. Create a Filter
Create a class that will be called after every request.
See example [here](presentation/Filters/CustomHeaderFilter.cs)

## 2. Register the Filter
In the main program, register the class:

```
builder.Services.AddMvc(options =>
{
    options.Filters.Add(typeof(CustomHeaderFilter));
});
```

## 3. Create a API Controller
Create any API/Controller you want or need.

## 4. Just call the API 
Call the API, and see the "extra" header added to all endpoints.

