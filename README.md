# spotify-win-scrape

A trivial demo of scraping the currently-playing track and artist from the native Spotify Windows application. Although Spotify has an API, it is severely restricted by rate-limits, to the point that it's effectively impossible to provide basic information like what the user is listening to anywhere near realtime (yeah, seriously).

This app just finds the Spotify window and dumps the track/artist info any time it changes. Polling is every 500ms.

Mostly I wrote it to see what Spotify does in certain edge cases, like after startup before anything is playing, or when a cheap-skate non-subscribing user is choking down some of that miserable dreck known as advertising.

People have been begging for first-class API support for this obvious use-case for many years, and Spotify is apparently uninterested in improving the situation. Discussion [here](https://community.spotify.com/t5/Spotify-for-Developers/Access-to-websockets/m-p/4955299) with links to many other closed/ignored discussions over the years. Ridiculous.
