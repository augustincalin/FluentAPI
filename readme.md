# FluentAPI
Sample project about how to create a fluent API with config action:
```c#
            var house = BuildingYard
                .CreateHouse(config =>
                {
                    config.HouseName = "Green Mansion";
                })
                .AddMainHallway()
                .AddLivingRoom()
                .AddKitchen()
                .Build();

```