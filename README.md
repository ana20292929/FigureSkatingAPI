# FigureSkatingAPI

## Description

FigureSkatingAPI is an API that allows new figure skating fans to learn about previously held competitions.

## How It Came To Be
I wanted to create an API that would help new figure skating fans keep up with the sport by getting information about competitions and skaters.

The initial idea for this API was an API that would store information about figure skaters and competitions. Information about the skaters would include their age, the country they represent, etc. Information about competitions would be the name of the competition, location, and the dates it will be held. The user will be able to get the information about either of these. However, the main purpose of this API would be to see upcoming competitions and which skaters will be participating in the said competition and where the competition can watched.

However, this idea changed to being centered around past competitions because I realized that despite it being difficult to find information about upcoming competitions, it is even more difficult to find information about past competitions. The information about skaters will still be shown, but now, the competitions will also display 10 skaters that participated in the competition. This will help new figure skating fans catch up on the past competitions.

## API Endpoints

In total, this API has 10 endpoints.

### Skater Endpoints

* GET api/Skater

Current Response:
```json
{
    "statusCode": 200,
    "statusDescription": "Ok: Fetched All Skaters",
    "skatersList": [
        {
            "skaterId": 1,
            "skaterFirstName": "Yuzuru",
            "skaterLastName": "Hanyu",
            "skaterCountry": "Japan",
            "skaterAge": 28
        },
        {
            "skaterId": 2,
            "skaterFirstName": "Nathan",
            "skaterLastName": "Chen",
            "skaterCountry": "USA",
            "skaterAge": 23
        },
        {
            "skaterId": 4,
            "skaterFirstName": "Kamila",
            "skaterLastName": "Valieva",
            "skaterCountry": "Russia",
            "skaterAge": 16
        },
        {
            "skaterId": 5,
            "skaterFirstName": "Shoma",
            "skaterLastName": "Uno",
            "skaterCountry": "Japan",
            "skaterAge": 25
        },
        {
            "skaterId": 6,
            "skaterFirstName": "Ilia",
            "skaterLastName": "Malinin",
            "skaterCountry": "USA",
            "skaterAge": 18
        },
        {
            "skaterId": 7,
            "skaterFirstName": "Jun-Hwan",
            "skaterLastName": "Cha",
            "skaterCountry": "South Korea",
            "skaterAge": 21
        },
        {
            "skaterId": 8,
            "skaterFirstName": "Yuma",
            "skaterLastName": "Kagiyama",
            "skaterCountry": "Japan",
            "skaterAge": 19
        },
        {
            "skaterId": 9,
            "skaterFirstName": "Anna",
            "skaterLastName": "Shcherbakova",
            "skaterCountry": "Russia",
            "skaterAge": 19
        },
        {
            "skaterId": 10,
            "skaterFirstName": "Alexandra",
            "skaterLastName": "Trusova",
            "skaterCountry": "Russia",
            "skaterAge": 18
        },
        {
            "skaterId": 11,
            "skaterFirstName": "Kaori",
            "skaterLastName": "Sakamoto",
            "skaterCountry": "Japan",
            "skaterAge": 23
        },
        {
            "skaterId": 12,
            "skaterFirstName": "Sui",
            "skaterLastName": "Wenjing",
            "skaterCountry": "China",
            "skaterAge": 27
        },
        {
            "skaterId": 13,
            "skaterFirstName": "Han",
            "skaterLastName": "Cong",
            "skaterCountry": "China",
            "skaterAge": 30
        },
        {
            "skaterId": 14,
            "skaterFirstName": "Evgenia",
            "skaterLastName": "Tarasova",
            "skaterCountry": "Russia",
            "skaterAge": 28
        },
        {
            "skaterId": 15,
            "skaterFirstName": "Vladimir",
            "skaterLastName": "Morozov",
            "skaterCountry": "Russia",
            "skaterAge": 30
        },
        {
            "skaterId": 16,
            "skaterFirstName": "Anastasia",
            "skaterLastName": "Mishina",
            "skaterCountry": "Russia",
            "skaterAge": 22
        },
        {
            "skaterId": 17,
            "skaterFirstName": "Aleksandr",
            "skaterLastName": "Galliamov",
            "skaterCountry": "Russia",
            "skaterAge": 23
        },
        {
            "skaterId": 18,
            "skaterFirstName": "Wakaba",
            "skaterLastName": "Higuchi",
            "skaterCountry": "Japan",
            "skaterAge": 22
        },
        {
            "skaterId": 19,
            "skaterFirstName": "Elizaveta",
            "skaterLastName": "Tuktamysheva",
            "skaterCountry": "Russia",
            "skaterAge": 26
        },
        {
            "skaterId": 20,
            "skaterFirstName": "Morisi",
            "skaterLastName": "Kvitelashvili",
            "skaterCountry": "Georgia",
            "skaterAge": 28
        },
        {
            "skaterId": 21,
            "skaterFirstName": "Jason",
            "skaterLastName": "Brown",
            "skaterCountry": "USA",
            "skaterAge": 28
        },
        {
            "skaterId": 22,
            "skaterFirstName": "Vincent",
            "skaterLastName": "Zhou",
            "skaterCountry": "USA",
            "skaterAge": 22
        },
        {
            "skaterId": 23,
            "skaterFirstName": "Karen",
            "skaterLastName": "Chen",
            "skaterCountry": "USA",
            "skaterAge": 23
        },
        {
            "skaterId": 24,
            "skaterFirstName": "Keegan",
            "skaterLastName": "Messing",
            "skaterCountry": "Canada",
            "skaterAge": 31
        }
    ],
    "competitionsList": []
}
```

* GET api/Skater/{id}

id is the skaterId

Current Response for skaterId 1:
```json
{
    "statusCode": 200,
    "statusDescription": "Ok: Fetched Requested Skater",
    "skatersList": [
        {
            "skaterId": 1,
            "skaterFirstName": "Yuzuru",
            "skaterLastName": "Hanyu",
            "skaterCountry": "Japan",
            "skaterAge": 28
        }
    ],
    "competitionsList": []
}
```

* PUT api/Skater/{id}

Let's say, the age of Yuzuru Hanyu needs to be changed. In the URL, id would be changed to 1, and the Request would look like this:
```json
{
    "SkaterID": 1,
    "SkaterFirstName": "Yuzuru",
    "SkaterLastName": "Hanyu",
    "SkaterCountry": "Japan",
    "SkaterAge": 29
}
```

Response:

```json
{
    "statusCode": 204,
    "statusDescription": "No Content: Successfully Updated",
    "skatersList": [],
    "competitionsList": []
}
```

* POST api/Skater

Let's add a new skater:

```json
{
    "SkaterFirstName": "tester",
    "SkaterLastName": "testing",
    "SkaterCountry": "Test",
    "SkaterAge": 20
}
```

Response:
```json
{
    "statusCode": 201,
    "statusDescription": "Created New Skater",
    "skatersList": [],
    "competitionsList": []
}
```

* DELETE api/Skater/{id}

Now, let's delete this new skater we added. Their id in this example was 27:
```json
{
    "SkaterID": 27,
    "SkaterFirstName": "tester",
    "SkaterLastName": "testing",
    "SkaterCountry": "Test",
    "SkaterAge": 20
}
```

Response:
```json
{
    "statusCode": 204,
    "statusDescription": "No Content: Successfully Deleted",
    "skatersList": [],
    "competitionsList": []
}
```

### Competition Endpoints

* GET api/Competition

Current Response:
```json
{
    "statusCode": 200,
    "statusDescription": "Ok: Fetched All Competitions",
    "skatersList": [],
    "competitionsList": [
        {
            "competitionId": 1,
            "competitionName": "2022 Winter Olympics",
            "competitionLocation": "China",
            "competitionStartDate": "2022-02-04T00:00:00",
            "competitionEndDate": "2022-02-20T00:00:00",
            "skaterID1": 1,
            "skaterID2": 2,
            "skaterID3": 4,
            "skaterID4": 5,
            "skaterID5": 7,
            "skaterID6": 8,
            "skaterID7": 9,
            "skaterID8": 10,
            "skaterID9": 11,
            "skaterID10": 18
        },
        {
            "competitionId": 2,
            "competitionName": "tester",
            "competitionLocation": "tester",
            "competitionStartDate": "2022-02-04T00:00:00",
            "competitionEndDate": "2022-02-20T00:00:00",
            "skaterID1": 1,
            "skaterID2": 2,
            "skaterID3": 4,
            "skaterID4": 5,
            "skaterID5": 7,
            "skaterID6": 8,
            "skaterID7": 9,
            "skaterID8": 10,
            "skaterID9": 11,
            "skaterID10": 18
        },
        {
            "competitionId": 4,
            "competitionName": "2021 World Figure Skating Championships",
            "competitionLocation": "Sweden",
            "competitionStartDate": "2021-03-24T00:00:00",
            "competitionEndDate": "2021-03-28T00:00:00",
            "skaterID1": 1,
            "skaterID2": 2,
            "skaterID3": 5,
            "skaterID4": 7,
            "skaterID5": 8,
            "skaterID6": 9,
            "skaterID7": 10,
            "skaterID8": 11,
            "skaterID9": 19,
            "skaterID10": 20
        }
    ]
}
```

* GET api/Competition/{id}

Current Response for id 4:
```json
{
    "statusCode": 200,
    "statusDescription": "Ok: Fetched Requested Competition",
    "skatersList": [],
    "competitionsList": [
        {
            "competitionId": 4,
            "competitionName": "2021 World Figure Skating Championships",
            "competitionLocation": "Sweden",
            "competitionStartDate": "2021-03-24T00:00:00",
            "competitionEndDate": "2021-03-28T00:00:00",
            "skaterID1": 1,
            "skaterID2": 2,
            "skaterID3": 5,
            "skaterID4": 7,
            "skaterID5": 8,
            "skaterID6": 9,
            "skaterID7": 10,
            "skaterID8": 11,
            "skaterID9": 19,
            "skaterID10": 20
        }
    ]
}
```

* PUT api/Competition/{id}

Let's say the name of one of the competition needs to be changed. Let's use competitionId 2. Change the id in the URL to 2. The Request would look like:

```json
{
    "competitionId": 2,
    "competitionName": "CHAGNING THE NAME",
    "competitionLocation": "tester",
    "competitionStartDate": "2022-02-04T00:00:00",
    "competitionEndDate": "2022-02-20T00:00:00",
    "skaterID1": 1,
    "skaterID2": 2,
    "skaterID3": 4,
    "skaterID4": 5,
    "skaterID5": 7,
    "skaterID6": 8,
    "skaterID7": 9,
    "skaterID8": 10,
    "skaterID9": 11,
    "skaterID10": 18
}
```

Response:

```json
{
    "statusCode": 204,
    "statusDescription": "No Content: Successfully Updated",
    "skatersList": [],
    "competitionsList": []
}
```

* POST api/Competition

Let's add a new (fake) competition:
```json
{
    "competitionName": "New Competition",
    "competitionLocation": "Mars",
    "competitionStartDate": "2022-02-04T00:00:00",
    "competitionEndDate": "2022-02-20T00:00:00",
    "skaterID1": 1,
    "skaterID2": 2,
    "skaterID3": 4,
    "skaterID4": 5,
    "skaterID5": 7,
    "skaterID6": 8,
    "skaterID7": 9,
    "skaterID8": 10,
    "skaterID9": 11,
    "skaterID10": 18
}
```

Response:
```json
{
    "statusCode": 201,
    "statusDescription": "Created New Competition",
    "skatersList": [],
    "competitionsList": []
}
```

* DELETE api/Competition/{id}

Let's delete the fake competition we created. It's id is 5.

Request:
```json
{
    "competitionId": 5,
    "competitionName": "New Competition",
    "competitionLocation": "Mars",
    "competitionStartDate": "2022-02-04T00:00:00",
    "competitionEndDate": "2022-02-20T00:00:00",
    "skaterID1": 1,
    "skaterID2": 2,
    "skaterID3": 4,
    "skaterID4": 5,
    "skaterID5": 7,
    "skaterID6": 8,
    "skaterID7": 9,
    "skaterID8": 10,
    "skaterID9": 11,
    "skaterID10": 18
}
```

Response:
```json
{
    "statusCode": 204,
    "statusDescription": "No Content: Successfully Deleted",
    "skatersList": [],
    "competitionsList": []
}
```
