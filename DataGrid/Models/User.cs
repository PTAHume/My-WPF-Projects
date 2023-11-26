using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataGrid.Models;

public partial class User : ObservableObject
{
    //usful for when non specift items on row, dont need to use reach up ulesss ie. name joe  is specal then list hear wouldnt make sense
    public List<string> UserTypes { get; } = new List<string>{
            "Admin",
            "Standard"
    };

    public Guid Id { get; } = Guid.NewGuid();

    [ObservableProperty]
    private string? _name;

    [ObservableProperty]
    private int _age;

    [ObservableProperty]
    public string? _type;

    [ObservableProperty]
    public string? _type2;
}