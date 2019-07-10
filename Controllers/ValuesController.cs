﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class ValuesController
{ 
    [HttpGet("/")]
    public string Hello() => "Hello World!";
    // GET api/values
    [HttpGet("/api/values")]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }
    // GET api/values/5
    [HttpGet("/api/values/{id}")]
    public string Get(int id)
    {
        return "Your value is " + id;
    }
}