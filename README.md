`NopModelBinder` inherits from `Binders.Ver217.ComplexTypeModelBinder` borrowed
from [ASP.NET Core 2.1.7](https://github.com/aspnet/AspNetCore/releases/tag/v2.1.7)
and everything work as expected.

Switching to the current implementation `Binders.ComplexTypeModelBinder` causes
an infinite loop.
