# MyAPI
A .NET Core 8 Web API

## Overview

This API Consists of one controller `PopulationController`, with one endpoint `GetPopulationByCountry` which takes no parameters and returns a list of US population counts by year using this publicly available [API Endpoint](https://datausa.io/api/data?drilldowns=Nation&measures=Population).

All of the logic for this is currently in the `PopulationController` using `HttpClient` to make the web request and the data is serialized to JSON via a simple POCO model.

## Instructions

You'll notice that there are two projects in this solution, one for the API and one for adding Tests to the API using xUnit.

1. Create unit tests using `moq` to test the data request. E2E tests are very valuable but are not what's being asked for.
1. Create any files/classes/objects/etc. required for to support the above.
1. When complete, please prepare a Pull Request to explain your refactor of the code.
1. (if time allows) Consider the use of `HttpClient` in the code. Are there better factors of that implementation?

Note: you may use any resources/packages/etc. for this refactor. As an optional note, you may also make any changes you deem would make for better code, so feel free to rename or re-organize anything in the project.

Note 2: you may use github copilot for this exercise, but please note _where_ and _why_ you did so in your PR. 