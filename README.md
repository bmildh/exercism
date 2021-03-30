# These are my exercism's, trying to learn fsharp.
## Table of Contents
- [Setup](#setup)
- [Anatomy of an Exercise](#anatomy-of-an-exercise)


## Setup

Go to exercism.io - instructions for the exercism cli is all there. Easy peasy. 

## Anatomy of an Exercise

The files for an exercise live in `exercises/<slug>`. The slug for an exercise
is a unique nickname composed of a-z (lowercase) and -, e.g.  `clock` or
`atbash-cipher`. Inside its directory, each exercise has:

* a test suite, `<exercise_name>_test.rb`
* an example solution, `.meta/solutions/<exercise_name>.rb`

where `<exercise_name>` is the underscored version of the exercise's slug,
e.g., `clock` or `atbash_cipher`.

If the exercise has a test generator, the directory will also contain:

* the test generator, `.meta/generator/<exercise_name>_case.rb`

A few exercises use a custom test template:

* `.meta/generator/test_template.erb`

## Running the Tests

Run the tests using `dotnet test`

