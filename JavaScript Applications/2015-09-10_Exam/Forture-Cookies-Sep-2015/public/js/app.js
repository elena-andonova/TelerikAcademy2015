(function() {
  var sammyApp = new Sammy('#content', function() {
    var $content = $('#content');

    this.get('#/', function(context) {
      context.redirect('#/home');
    });

    this.get('#/home', function(context) {
      var cookies;
      var category = context.params.category || null;

      data.cookies.getAll()
        .then(function(resCookies) {
          cookies = resCookies;

          if (category) {
            cookies = resCookies.filter(controllerHelpers.filterByCategory(category));
          }

          return templates.get('cookies');
        })
        .then(function(template) {
          context.$element().html(template(cookies))
        });


      $('#content').on('click', '.share', function() {
        var parent = $(this).parent();
        var category = parent.find('.category').html();
        var text = parent.find('.text').html();
        var img = parent.find('.img').attr('src');

        var cookie = {
          text: text,
          category: category,
          img: img
        };

        data.cookies.add(cookie)
          .then(function(cookie) {
            toastr.success(`Cookie "${cookie.text}" shared!`);
            setTimeout(function() {
              context.redirect('#/home');
              document.location.reload(true);
            }, 800)
          });
      });

      $('#content').on('click', '#like', function() {
        console.log('like clicked')
        var parent = $(this).parent();
        var id = parent.attr('data-id');

        data.cookies.like(id)
          .then(function(cookie) {
            toastr.success(`Cookie "${cookie.text}" liked!`);
            setTimeout(function() {
              context.redirect('#/home');
              document.location.reload(true);
            }, 800)
          });
      });

      $('#content').on('click', '#dislike', function() {
        var parent = $(this).parent();
        var id = parent.attr('data-id');

        data.cookies.dislike(id)
          .then(function(cookie) {
            toastr.success(`Cookie "${cookie.text}" disliked!`);
            setTimeout(function() {
              context.redirect('#/home');
              document.location.reload(true);
            }, 800)
          });
      });

    });

    this.get('#/home/add', function(context) {
      templates.get('cookies-add')
        .then(function(template) {
          context.$element()
            .html(template());
          return data.categories.get();
        })
        .then(function(categories) {
          $('#tb-cookie-category').autocomplete({
            source: categories
          });

          $('#btn-cookie-share').on('click', function() {
            var cookie = {
              text: $('#tb-cookie-text').val(),
              category: $('#tb-cookie-category').val(),
              img: $('#tb-cookie-image').val()
            };

            data.cookies.add(cookie)
              .then(function(cookie) {
                toastr.success(`Cookie "${cookie.text}" added!`);
                context.redirect('#/home');
              });
          });

        });
    })


    this.get('#/home/sorted-by-likes', function(context) {
      console.log('by likes')
      var cookies;

      data.cookies.getAll()
        .then(function(resCookies) {
          cookies = _.chain(resCookies).sortBy(function(cookie){
            return -(cookie.likes);
          }).value();

          return templates.get('cookies');
        })
        .then(function(template) {
          console.log('Here')
          context.$element().html(template(cookies))
          console.log('There')
        });
    })

    this.get('#/home/sorted-by-dates', function(context) {
      console.log('by dates')
      var cookies;

      data.cookies.getAll()
        .then(function(resCookies) {
          cookies = _.chain(resCookies).sortBy(function(cookie){
            return -(cookie.shareDate);
          }).value();

          return templates.get('cookies');
        })
        .then(function(template) {
          context.$element().html(template(cookies))
        });
    })

    this.get('#/my-cookie', function() {
      if (data.users.current()) {
        var cookie;
        data.cookies.getCookie()
          .then(function(res) {
            cookies = res;
            return templates.get('my-cookie');
          })
          .then(function(template) {
            $content.html(template(cookies));
          });
      } else {
        $content.html("Please login to see your cookie..");
      }
      console.log('me cookie')
    });


    this.get('#/users', function(context) {
      templates.get('register')
        .then(function(template) {
          $content.html(template());

          $('#btn-login').on('click', function() {
            var user = {
              username: $('#tb-user').val(),
              password: $('#tb-pass').val()
            };

            data.users.login(user)
              .then(function(user) {
                console.log('user is logged in')
                context.redirect('#/');
                //document.location.reload(true);
              });
          });

          $('#btn-register').on('click', function() {
            var user = {
              username: $('#tb-user').val(),
              password: $('#tb-pass').val()
            };

            data.users.register(user)
              .then(function(user) {
                toastr.success('User is registered! You can log-in now...')
                  // context.redirect('#/');
                  // document.location.reload(true);
              });
          });
        });
    });


  });

  $(function() {
    sammyApp.run('#/home');

    if (data.users.current()) {
      $('#btn-go-to-login')
        .addClass('hidden');
    } else {
      $('#btn-logout')
        .addClass('hidden');
    }

    $('#btn-logout').on('click', function() {
      data.users.logout()
        .then(function() {
          location = '#/';
          document.location.reload(true);
        });
    });
  })
}());
