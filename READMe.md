# OzowSorter

Foobar is a C# console program that takes any arbitrary piece of text as input, and returns as
output a sorted list of letters. Punctuation should be ignored, and uppercase
letters should be mapped to lowercase..

### Example
```bash
input: Contrary to popular belief, the pink unicorn flies east. 
output: aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy
```

## Approach
The project was built in a TDD fashion. Unit tests were used to drive the design. 


## Requirements to Build Project

```python
import foobar

foobar.pluralize('word') # returns 'words'
foobar.pluralize('goose') # returns 'geese'
foobar.singularize('phenomena') # returns 'phenomenon'
```


## License
[MIT](https://choosealicense.com/licenses/mit/)