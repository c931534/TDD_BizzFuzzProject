﻿using BizzFuzzProject;
using NUnit.Framework;

namespace BizzFuzzProject.Tests;

[TestFixture]
[TestOf(typeof(BizzFuzzService))]
public class BizzFuzzServiceTest
{
    private BizzFuzzService _service;

    public BizzFuzzServiceTest()
    {
        _service = new BizzFuzzService();
    }
    
    /// <summary>
    /// 所有數字回傳
    /// </summary>
    [Test]
    public void Return_Number()
    {
        Assert.That("1", Is.EqualTo(_service.Query(1)));
    }

    /// <summary>
    /// 可以被3整除地要回傳bizz
    /// </summary>
    [Test]
    public void Return_Bizz()
    {
        Assert.That(_service.Query(3), Is.EqualTo("Bizz"));
    }
    
    /// <summary>
    /// 可以被3整除地要回傳bizz
    /// </summary>
    [Test]
    public void Return_Fuzz()
    {
        Assert.That(_service.Query(5), Is.EqualTo("Fuzz"));
    }
}