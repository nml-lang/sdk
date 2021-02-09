# JLML

JLML (json like markup language) is a markup language concept in a json like format

## Document breakdown

### Top level

A jlml document is at the top level comprised of two or more things:

- [Headers](https://nml-lang.github.io/sdk/api/headers.md).
These are either a `declare` or `set` statement
  - [Declare](). `declare jlml "jlml.github.io/pack/";`
  - [Set](). `set page.title "JLML Page";`
- [Base Element/Elements](https://nml-lang.github.io/sdk/api/elements.md). Every document has to have at least one but can have more. This can optionally be an named element
  - [Elements](https://nml-lang.github.io/sdk/api/elements.md).
  `{ ... }`
  - [Named element](https://nml-lang.github.io/sdk/api/named_elements.md).
  `nav: { ... }`

### Lower levers

Going deeper in the base element you have a few more things.

- [Values](https://nml-lang.github.io/sdk/api/values.md). An element can have a number of values
  - `tags: "container";`
- [Options](https://nml-lang.github.io/sdk/api/options.md). These can be used to import other code or give conditions to elements
  - [Import options](https://nml-lang.github.io/sdk/api/import_options.md). `using jlml.nav;`
  - [Conditional options](https://nml-lang.github.io/sdk/api/conditional_options.md). `if page.width < 900`

## Complete sample

```lang-default
// Headers statements
declare jlml "jlml.github.io/pack";
declare images "jlml.github.io/images";

// Document base element
{
    tags: "container";

    // Value with an using option
    nav: using jlml.nav;

    image: if page.width < 900
    {
        src: (images, "placeholder-600x400");
        description: {
            text: "Only shown when screen is smaller then 900 pixels"
        }
    }

    {
        text: "this always has 1/3 of the width of the page wide";
        width: page.width / 3;
    }
}
```
