/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];

		function listBooks(param) {
			if(arguments.length > 0) {
				if (typeof (param.category) !== 'undefined') {
					return typeof (categories[param.category]) !== 'undefined' ? categories[param.category].books : [];

				}
				if (typeof (param.author) !== 'undefined') {
					var newArr = books.filter(function(item) {
						return item.author === param.author;
					})
					return newArr.length !== 0 ? newArr : [];

				}
			}

			return books;
		}

		function addBook(book) {
			book.ID = books.length + 1;

			if((categories.indexOf(book.category)) === -1) {
				categories[book.category] = {
					books: [],
					id: categories.length + 1
				};

			}

			if(book.title.length < 2 || book.title.length > 100) {
				throw  new Error();
			}
			if(book.category.length < 2 || book.category.length > 100) {
				throw  new Error();
			}
			if(book.author === "") {
				throw new Error();
			}
			if(book.isbn.length < 10 || book.isbn.length > 13) {
				throw new Error();
			}
			if(books.some(function(item) {return item.title === book.title;})) {
				throw new Error();
			}
			if(books.some(function(item) {return item.isbn === book.isbn;})) {
				throw new Error();
			}

			categories[book.category].books.push(book);
			books.push(book);

			return book;
		}

		function listCategories(param) {
			var cat = [];

			//if(arguments.length > 0) {

				Array.prototype.push.apply(cat, Object.keys(categories));
				return cat;
			//}
			//return categories;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;
