var controllerHelpers = function() {
  function groupByCategory(item) {
    return item.category;
  }

  function parseGroups(items, category) {
    return {
      category,
      items
    };
  }

  function filterByCategory(category) {
    return function(group) {
      return group.category.toLowerCase() === category.toLowerCase();
    };
  }

  return {
    groupByCategory, parseGroups, filterByCategory
  };
}();
