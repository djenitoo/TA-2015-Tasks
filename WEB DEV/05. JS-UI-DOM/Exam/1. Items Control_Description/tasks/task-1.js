function solve() {
  return function (selector, isCaseSensitive) {
    var root = document.querySelector(selector);
    var nodeLI = document.createElement('li');
    var isCaseSensitive = false;
    if(arguments[1]) {
      isCaseSensitive = true;
    }
    var divAdd = document.createElement('div');

    divAdd.className = 'add-controls';
    var text = document.createElement('label');
    text.innerHTML = 'Enter text';
    var inputEl = document.createElement('input');
    var addButton = document.createElement('div');
    addButton.className = 'button';
    addButton.innerHTML = 'Add';
    divAdd.appendChild(text);
    divAdd.appendChild(inputEl);
    divAdd.appendChild(addButton);

    var divSearch = document.createElement('div');
    divSearch.className = 'search-controls';
    var searchLabel = document.createElement('label');
    searchLabel.innerHTML = 'Search:';
    var inputSearch = document.createElement('input');
    divSearch.appendChild(searchLabel);
    divSearch.appendChild(inputSearch);


    var divResult = document.createElement('div');
    divResult.className = 'result-controls';
    var itemsUl = document.createElement('ul');
    itemsUl.className = 'items-list';
    divResult.appendChild(itemsUl);


    addButton.addEventListener('click', function (ev) {
      var target = ev.target;
      //if (!(target instanceof HTMLImageElement)) {
      //  return;
      //}

      var currLi = nodeLI.cloneNode(true);
      var XButton = document.createElement('div');
      var inpText = document.createElement('strong');
      XButton.className = 'button';
      XButton.innerHTML = 'X';
      currLi.appendChild(XButton);
      currLi.className = 'list-item';
      XButton.style.display = 'inline-block';

      inpText.innerHTML = inputEl.value;
      currLi.appendChild(inpText);

      itemsUl.appendChild(currLi);



    }, false);

    inputSearch.addEventListener('keyup', function (ev) {
      var target = ev.target;
      var searchedText = ev.target.value;

      var liChildren = document.getElementsByTagName('li');
      //if (!(target instanceof HTMLImageElement)) {
      //  return;
      //}
      for(var i = 0, len = liChildren.length; i < len; i += 1) {
        var currLi = liChildren[i];
        var head = currLi.getElementsByTagName('strong')[0].innerHTML;
        console.log(head);
        

        if(1) {
          if(head.indexOf(searchedText) >= 0) {
              currLi.style.display = 'block';
          }
          else {
            currLi.style.display = 'none';
          }
        }
        // } else {
        //   if(head.toLowerCase().indexOf(searchedText.toLowerCase()) >= 0) {
        //     currLi.style.display = 'block';
        //   }
        //   else {
        //     currLi.style.display = 'none';
        //   }
        // }


      }
    }, false);


    root.appendChild(divAdd);
    root.appendChild(divSearch);
    root.appendChild(divResult);
  };
}

module.exports = solve;