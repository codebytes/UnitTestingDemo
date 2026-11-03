<!-- Keep in sync with AGENTS.md at the repository root. -->

# Agent instructions: UnitTestingDemo

This repository holds the demo code for Chris Ayers' talk **Dependency Injection and Unit Testing in .NET Core**.

## Repository layout

- `UnitTestingDemo.sln`: solution for every project below.
- `src/UnitTestingDemo/`: ASP.NET Core web app.
- `src/UnitTestingDemo.Domain/`, `src/UnitTestingDemo.Data/`, `src/UnitTestingDemo.Services/`: domain model, EF Core data layer, and services wired through dependency injection.
- `tests/`: MSTest projects, one per layer.
- `global.json`: pins the .NET SDK.

## Build and run

```bash
dotnet restore
dotnet build --configuration Release --no-restore
dotnet test --no-restore --verbosity normal
```

## Talk-specific rules

- The code is a teaching sample: keep each layer small and keep dependencies injected through interfaces so the tests stay easy to read.
- `.github/workflows/dotnetcore.yml` runs the build and tests; CodeQL, super-linter, OSSAR, and ShiftLeft workflows scan pull requests. `azure-pipelines.yml` is the original Azure Pipelines version of the same build.

## README

- Keep the README sections in this order: Recordings, Resources (where present).
- When a new recording of the talk is published, add it at the top of `## Recordings` as `- [Event Year](https://www.youtube.com/watch?v=VIDEO_ID)`. When the video's title differs from the talk's, add an em dash and the recorded title after the event. Keep the list newest first.
- The talk also appears on <https://chris-ayers.com/speaking/> (source: `content/speaking.md` in [codebytes/codebytes.github.io](https://github.com/codebytes/codebytes.github.io)); new events and recordings belong there too.

## General

- Keep changes scoped to the request; don't reformat unrelated slides or code.
- Never commit secrets, keys, or connection strings. Demo placeholders must be obviously fake.
