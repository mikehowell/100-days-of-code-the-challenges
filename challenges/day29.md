## Day 28 ##

### Pig Latin I ###

Example from [GitHub Repo](https://github.com/AlanBarber/CodeKatas).

##Introduction##
>Pig Latin is a constructed language game where words in English are altered according to a simple set of rules. Pig Latin takes the first consonant (or consonant cluster) of an English word, moves it to the end of the word and suffixes an ay
>
> -<cite>-[Wikipedia (Pig Latin)](http://en.wikipedia.org/wiki/Pig_Latin)</cite>

## Rules ##

1. Words that begin with a vowel (a, e, i, o, u) should have "way" appended to the end of the word.
1. Words that begin with consonant have all consonant letters up the first vowel moved to the end of the word and append "ay" to the end

## Test Cases ##
1. `PigLatin_returns_ellohay_for_input_hello()`
1. `PigLatin_returns_iway_for_input_i()`
1. `PigLatin_returns_oveglay_for_input_glove()`
 


## Extra Credit ##

Ensure the `EnglishToPigLatin()` method takes an entire sentence in English, and returns the sentence in Pig Latin.

### Extra Credit Test Cases###
1. `PigLatin_returns_EthayIckquayOwnbrayOxfayOverwayEthayAzylayOgday_for_input_TheQuickBrownFoxJumpsOverTheLazyDog()`
1. `PigLatin_returns_OdecayAtaskaArewayAwayOodgayAywayOtayOnehayOuryayIllsskay_for_input_()`

