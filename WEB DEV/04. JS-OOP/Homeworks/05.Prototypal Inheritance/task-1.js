function solve() {
	var domElement = (function () {
		function validateType(elem) {
			if (typeof elem !== 'string' || !(/^[A-Z0-9]+$/i.test(elem))) {
				throw new Error();
			}
			return  true;
		}

		function validateAttribute(name) {
			if (typeof name !== 'string' || !(/^[A-Z0-9\-]+$/i.test(name))) {
				throw new Error();
			}
			return  true;
		}
		function parseAttributes(attributes) {
			var result = '';
			var keys = [];
			for (var ind in attributes) {
				keys.push(ind);
			}
			keys.sort();

			for (var key in keys) {
				result += ' ' + keys[key] + '="' + attributes[keys[key]] + '"';
			}

			return result;
		}
		// function parseElement(element) {
		// 	return '<' + element.name + parseAttributes(this.attributes) +
		// 	'>' + ((this.content !== '') ? this.content : parseElement(this.parent)) +
		// 	 '</' + element.name + '>';
		// }
		var domElement = {
			init: function(type) {
				this.name = type;
				this.attributes = [];
				this.content = '';
				this.parent;
				this.children = [];

				return this;
			},
			appendChild: function(child) {
				this.children.push(child);

				if(typeof child === 'object') {
					child.parent = this;
				}

				return this;
			},
			addAttribute: function(name, value) {
				validateAttribute(name);
				this.attributes[name] = value;

				return this;
			},
			removeAttribute: function(attribute) {
				if(typeof this.attributes[attribute] === 'undefined') {
					throw new Error();
				}
				delete this.attributes[attribute];

				return this;
			},
      get innerHTML(){
		  	var result = '<' + this.name +
			  parseAttributes(this.attributes) +
			  '>';
			  for (var index = 0; index < this.children.length; index++) {
					  if (typeof this.children[index] === 'string') {
						  result += this.children[index];
					  }
					  else {
						  result += this.children[index].innerHTML;
					  }
				  }

				  result += this.content;

			  result += '</' + this.name + '>';

			  return result;
      },

		get name() {
			return this._name;
		},
		set name(value) {
			validateType(value);
			this._name = value;
		},
		get content() {
			if(this.children.length) {
				return '';
			}
			return this._content;
		},
		set content(value) {
			this._content = value;
		},
		get attributes() {
			return this._attributes;
		},
		set attributes(value) {
			this._attributes = value;
		},
		get children() {
			return this._children;
		},
		set children(value) {
			this._children = value;
		},
		get parent() {
			return this._parent;
		},
		set parent(value) {
			this._parent = value;
		}
		};
		return domElement;
	} ());
	return domElement;
}

module.exports = solve;
