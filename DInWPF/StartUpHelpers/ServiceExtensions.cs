using Microsoft.Extensions.DependencyInjection;

namespace DInWPF.StartUpHelpers;

public static class ServiceExtensions
{
    // form factory pattern
    public static void AddFormFactory<TFrom>(this IServiceCollection services)
        where TFrom : class
    {
        //Add the form (a generic)
        //e.g. add ChildForm as transient
        services.AddTransient<TFrom>();
        //add Func of the form which is a delegate that create the from when delegate is run,
        //adding the delegate to DI not the form, so x.GetService<TFrom>() is run when this is called
        //e.g. add func of ChildForm that get the ChildForm
        services.AddSingleton<Func<TFrom>>(x => () => x.GetService<TFrom>()!);
        //IAbstractFactory will run the delegate  public T Create() { ...
        //e.g. add IAbstractFactory of type ChildForm to give ChildForm
        services.AddSingleton<IAbstractFactory<TFrom>, AbstractFactory<TFrom>>();
    }
}