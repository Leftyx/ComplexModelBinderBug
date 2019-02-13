`NopModelBinder` inherits from `Binders.Ver217.ComplexTypeModelBinder` borrowed
from [ASP.NET Core 2.1.7](https://github.com/aspnet/AspNetCore/releases/tag/v2.1.7)
and everything work as expected.

Switching to the current implementation `Binders.ComplexTypeModelBinder` causes
an infinite loop.

~~Switching to the current implementation `Binders.ComplexTypeModelBinder` causes
an infinite loop.~~

Switching to commit https://github.com/aspnet/AspNetCore/commit/5bbf7109a5ed3bf38d5d3d8bd9ff868097f7bc9c

`Binders.ComplexTypeModelBinder` causes
an infinite loop.
