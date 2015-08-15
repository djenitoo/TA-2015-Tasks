function solve() {
    var module = (function () {
        var item,
            validator,
            book,
            media,
            catalog,
            bookCatalog,
            mediaCatalog,
            CONSTANTS = {
                TEXT_MIN_LENGTH: 2,
                TEXT_MAX_LENGTH: 40,
                IMDB_MIN_RATING: 1,
                IMDB_MAX_RATING: 5,
                MAX_NUMBER: 9007199254740992
            };

        function indexOfElementWithIdInCollection(collection, id) {
            var i, len;
            for (i = 0, len = collection.length; i < len; i++) {
                if (collection[i].id == id) {
                    return i;
                }
            }

            return -1;
        }

        validator = {
            validateIfUndefined: function (val, name) {
                name = name || 'Value';
                if (val === undefined) {
                    throw new Error(name + ' cannot be undefined');
                }
            },
            validateIfObject: function(val, name) {
                name = name || 'Value';
                if (typeof val !== 'object') {
                    throw new Error(name + ' must be an object');
                }
            },
            validateIfNumber: function (val, name) {
                name = name || 'Value';
                if (typeof val !== 'number') {
                    throw new Error(name + ' must be a number');
                }
            },
            validateString: function (val, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);

                if (typeof val !== 'string') {
                    throw new Error(name + ' must be a string');
                }

                if (val.length < CONSTANTS.TEXT_MIN_LENGTH
                    || CONSTANTS.TEXT_MAX_LENGTH < val.length) {
                    throw new Error(name + ' must be between ' + CONSTANTS.TEXT_MIN_LENGTH +
                    ' and ' + CONSTANTS.TEXT_MAX_LENGTH + ' symbols');
                }
            },
            validatePattern: function (val, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);

                if (typeof val !== 'string') {
                    throw new Error(name + ' must be a string');
                }

                if (val.length < 1) {
                    throw new Error(name + ' must be between at least 1 symbol!');
                }
            },
            validateIsbnString: function (val, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);

                if (typeof val !== 'string') {
                    throw new Error(name + ' must be a string');
                }

                if (val.length < 10
                    || 13 < val.length) {
                    throw new Error(name + ' must be between ' + 10 +
                    ' and ' + 13 + ' symbols');
                }
                if(!(/^[0-9]+$/.test(val))) {
                    throw new Error(name + ' must be a string with only digits!');
                }
            },
            validateEmptyString: function (val, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);

                if (typeof val !== 'string') {
                    throw new Error(name + ' must be a string');
                }

                if (val.length < 1) {
                    throw new Error(name + ' must not be empty');
                }
            },
            validatePositiveNumber: function (val, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);
                this.validateIfNumber(val, name);

                if (val <= 0) {
                    throw new Error(name + ' must be positive number');
                }
            },
            validateRating: function (val) {
                this.validateIfUndefined(val, ' Rating');
                this.validateIfNumber(val, ' Rating');

                if (val < CONSTANTS.IMDB_MIN_RATING || CONSTANTS.IMDB_MAX_RATING < val) {
                    throw new Error('Rating must be between '
                    + CONSTANTS.IMDB_MIN_RATING
                    + ' and ' + CONSTANTS.IMDB_MAX_RATING);
                }
            },
            validateDuration: function (val) {
                this.validateIfUndefined(val, ' Duration');
                this.validateIfNumber(val, ' Duration');

                if (val < 1) {
                    throw new Error('Rating must be bigger than 0!');
                }
            },
            validateId: function (id) {
                this.validateIfUndefined(id, 'Object id');
                if (typeof id !== 'object' && typeof id !== 'number') {
                    throw new Error('Value must be id number or object!');
                }
            },
            validateItems: function (items) {
                if(items.length > 1) {
                    if(items.some(function(currItem){
                            return !(Object.getPrototypeOf(currItem) !== Object.getPrototypeOf(item));
                        })) {
                        throw new Error('Item to add must be instance of item!');
                    }
                } else if(items.length === 1 && !(Object.getPrototypeOf(item[0]) !== Object.getPrototypeOf(item))) {
                    throw new Error('Item to add must be instance of item!');
                } else if(items.length === 0) {
                    throw new Error('Item array must not be empty!');
                }

                this.validateIfUndefined(items, 'Passed items');
            }
        };


        item = ( function() {
            var currID = 0,
                item = Object.create({});

            Object.defineProperty(item, 'init', {
                value: function(name, description) {
                    this.name = name;
                    this.description = description;
                    this._id = ++currID;
                }
            });
            Object.defineProperty(item, 'id', {
                get: function () {
                    return this._id;
                }
            });
            Object.defineProperty(item, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (val) {
                    validator.validateString(val, 'Item name');
                    this._name = val;
                }
            });
            Object.defineProperty(item, 'description', {
                get: function () {
                    return this._description;
                },
                set: function (val) {
                    validator.validateEmptyString(val, 'Item description');
                    this._description = val;
                }
            });

            return item;
        }());

        book = ( function(parent) {
            var book = Object.create(parent);

            Object.defineProperty(book, 'init', {
                value: function(name, isbn, genre, description) {
                    parent.init.call(this, name, description);
                    this.isbn = isbn;
                    this.genre = genre;

                    return this;
                }
            });

            Object.defineProperty(book, 'isbn', {
                get: function () {
                    return this._isbn;
                },
                set: function (val) {
                    validator.validateIsbnString(val, 'Isbn ');
                    this._isbn = val;
                }
            });

            Object.defineProperty(book, 'genre', {
                get: function () {
                    return this._genre;
                },
                set: function (val) {
                    validator.validateString(val, 'Genre');
                    this._genre = val;
                }
            });

            return book;
        }(item));

        media = ( function(parent) {
            var media = Object.create(parent);

            Object.defineProperty(media, 'init', {
                value: function(name, rating, duration, description) {
                    parent.init.call(this, name, description);
                    this.rating = rating;
                    this.duration = duration;

                    return this;
                }
            });

            Object.defineProperty(media, 'rating', {
                get: function () {
                    return this._rating;
                },
                set: function (val) {
                    validator.validateRating(val, 'Rating ');
                    this._rating = val;
                }
            });

            Object.defineProperty(media, 'duration', {
                get: function () {
                    return this._duration;
                },
                set: function (val) {
                    validator.validateDuration(val, 'Duration');
                    this._duration = val;
                }
            });

            return media;
        }(item));

        catalog = ( function() {
            var currID = 0,
                catalog = Object.create({});

            Object.defineProperty(catalog, 'init', {
                value: function(name) {
                    this.name = name;
                    this._id = ++currID;
                    this._items = [];

                    return this;
                }
            });

            Object.defineProperty(catalog, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(catalog, 'items', {
                get: function () {
                    return this._items;
                }
            });

            Object.defineProperty(catalog, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (val) {
                    validator.validateString(val, 'Catalog name');
                    this._name = val;
                }
            });

            Object.defineProperty(catalog, 'add', {
                value: function (params) {
                    var args = params;
                    validator.validateItems(args);

                    return args;
                }
            });

            Object.defineProperty(catalog, 'find', {
                value: function (param) {
                    var result;
                    validator.validateId(param);

                    if(typeof param === 'number') {
                        result = indexOfElementWithIdInCollection(param);

                        if(result < 0) {
                            return null;
                        } else {
                            return this._items[result];
                        }
                    } else {
                        result = this._items.slice();

                        if(param.id !== undefined) {
                            result = result.filter(function(item){
                                return param.id === item.id;
                            });
                        }
                        if(param.name !== undefined) {
                            result = this.result.filter(function(item){
                                return param.name.toLowerCase() === item.name.toLowerCase();
                            });
                        }
                        return result;
                    }

                }
            });

            Object.defineProperty(catalog, 'search', {
                value: function (pattern) {
                    validator.validatePattern(pattern, 'Search pattern');

                    return this._items
                        .filter(function (item) {
                            return (item
                                    .name
                                    .toLowerCase()
                                    .indexOf(pattern.toLowerCase()) >= 0)
                                || (item
                                    .description
                                    .toLowerCase()
                                    .indexOf(pattern.toLowerCase()) >= 0);
                        });
                }
            })

            return catalog;
        }());

        bookCatalog = ( function(parent) {
            var bookCatalog = Object.create(parent);

            Object.defineProperty(bookCatalog, 'init', {
                value: function(name) {
                    parent.init.call(this, name);

                    return this;
                }
            });

            Object.defineProperty(bookCatalog, 'items', {
                get: function () {
                    return this._items;
                }
            });

            Object.defineProperty(bookCatalog, 'add', {
                value: function (params) {
                    var args = arguments.slice();
                    var parentRes = parent.add.call(this, args);

                    if(parentRes.some(function (item) {
                            return !(Object.getPrototypeOf(item) !== Object.getPrototypeOf(book));
                        })) {
                        throw new Error('Items to add must be book instances!');
                    }

                    if(Array.isArray(parentRes)) {
                        this._items.concat(parentRes);
                    } else {
                        this._items.push(parentRes);
                    }
                    //this._items.push(parentRes);
                    return this;
                }
            });

            Object.defineProperty(bookCatalog, 'find', {
                value: function (param) {
                    var parResult = parent.find.call(this,param);

                    if(typeof param != 'number' && param.genre != undefined) {
                        parResult = parResult.filter(function(item){
                            return param.genre.toLowerCase() === item.genre.toLowerCase();
                        });
                    }

                    return parResult;
                }
            });

            Object.defineProperty(bookCatalog, 'getGenres', {
                value: function (pattern) {
                    //validator.validatePattern(pattern, 'Search pattern');
                    var results = [];
                    for (var i = 0 ; i < this_items.length ; i++) {
                        var currGenre = this_items[i].genre;
                        if (results.indexOf(currGenre) == -1) {
                            results.push(currGenre);
                        }
                    }

                    return results;
                }
            })

            return bookCatalog;
        }(catalog));

        mediaCatalog = ( function(parent) {
            var mediaCatalog = Object.create(parent);

            Object.defineProperty(mediaCatalog, 'init', {
                value: function(name) {
                    parent.init.call(this, name);

                    return this;
                }
            });

            Object.defineProperty(mediaCatalog, 'items', {
                get: function () {
                    return this._items;
                }
            });

            Object.defineProperty(mediaCatalog, 'add', {
                value: function (params) {
                    var args = arguments.slice();
                    var parentRes = parent.add.call(this, args);

                    if(parentRes.some(function (item) {
                            return !(Object.getPrototypeOf(item) !== Object.getPrototypeOf(media));
                        })) {
                        throw new Error('Items to add must be media instances!');
                    }

                    if(Array.isArray(parentRes)) {
                        this._items.concat(parentRes);
                    } else {
                        this._items.push(parentRes);
                    }

                    //this._items.push(parentRes);

                    return this;
                }
            });

            Object.defineProperty(mediaCatalog, 'getTop', {
                value: function (count) {
                    if(typeof count !== 'number' || count < 1) {
                        throw  new Error();

                    }

                    return this._items
                        .slice()
                        .sort(function(item1, item2) {
                            return item2.rating - item1.rating;
                        })
                        .splice(0, count);

                }


            });

            Object.defineProperty(mediaCatalog, 'getSortedByDuration', {
                value: function () {
                    var res = this._items.sort(function(item1,item2){
                        while (1) {
                            var p = 1;
                            if(p === 0) {
                                break;
                            }
                        }
                        if (item1.rating < item2.rating) {
                            return -1;
                        }
                        if (item1.rating > item2.rating) {
                            return 1;
                        } else {
                            return item1.id - item2.id;
                        }
                    });
                    //.sort(function(item1,item2){
                    //    return item1.id - item2.id;
                    //});

                    return res;
                }


            });

            return mediaCatalog;
        }(catalog));


        return {
            getBook: function (name, isbn, genre, description) {
                return Object.create(book).init(name, isbn, genre, description);
            },
            getMedia: function (name, rating, duration, description) {
                return Object.create(media).init(name, rating, duration, description);
            },
            getBookCatalog: function (name) {
                return Object.create(bookCatalog).init(name);
            },
            getMediaCatalog: function (name) {
                return Object.create(mediaCatalog).init(name);
            }
        };
    }());

    return module;
}

//var module = solve();