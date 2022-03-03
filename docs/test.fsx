#load "YahooFinance.fsx"

open YahooFinance

let ticker = YahooFinance.PriceHistory("AAPL")

ticker.[..3]

#r "nuget: Plotly.NET,2.0.0-preview.17"

open Plotly.NET

ticker |> List.map (fun x -> x.Date, x.AdjustedClose)
|> Chart.Line |> GenericChart.toChartHTML

(***include-it-raw***)

let list = [1;2;3]
list

(***include-it***)