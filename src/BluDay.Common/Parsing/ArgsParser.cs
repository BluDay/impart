using System.Reflection;

namespace BluDay.Common.Parsing;

public static class ArgsParser
{
    public readonly static BindingFlags PropertyBindingFlags;

    static ArgsParser()
    {
        PropertyBindingFlags = BindingFlags.Instance
            | BindingFlags.DeclaredOnly
            | BindingFlags.Public;
    }

    public static TOptions Parse<TOptions>(string args) where TOptions : new()
    {
        return Parse<TOptions>(args: args.Split(Constants.Whitespace));
    }

    public static TOptions Parse<TOptions>(params string[] args) where TOptions : new()
    {
        var optionsType = typeof(TOptions);

        object? options = Activator.CreateInstance(optionsType);

        PropertyInfo[] properties = optionsType.GetProperties(PropertyBindingFlags);

        foreach (var property in properties)
        {
            var attribute = property.GetCustomAttribute<CommandLineArgAttribute>();

            if (attribute is null) continue;

            for (int index = 0; index < args.Length; index++)
            {
                // ( 0 _ o )
            }
        }

        return (TOptions)options!;
    }
}