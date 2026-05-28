# nservicebus-sql-script-repro
Minimal reproduction to demonstrate mixed line breaks in NServiceBus generated SQL scripts.

## Prerequisites
- Linux machine to see the problem in action.
- .NET 10.0.203 SDK. See `global.json`

## Interesting bits
The `Assembly.cs` defines the script generation configuration.
The `nsb_scripts` folder contains the generated scripts that are committed to the repository to detect differences.
This is as described in https://docs.particular.net/persistence/sql/controlling-script-generation

## Reproduce
- clone the repo `https://github.com/philippdolder/nservicebus-sql-script-repro`
- start a terminal and navigate to the repo root
- execute `git ls-files --eol | grep ".sql$"` -> you will see all line endings are `i/lf w/lf`. `i` is the index (e.g. what's in the repo), `w` is the working copy state.
- execute `dotnet build`
- execute `git status` to see all .sql files are modified
- execute `git ls-files --eol | grep ".sql$"` again -> you will see the `Outbox*.sql` files have `w/crlf` and `Sagas/*.sql` files have `w/mixed` line endings now.
- you can visualize line endings with e.g. `cat -vET Service/nsb_scripts/MsSqlServer/Sagas/DummySaga_Create.sql` -> there is a mix of `lf` ($) and `crlf` (^M$).
