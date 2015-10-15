(function() {
  var sammyApp = new Sammy('#content', function() {
    var $content = $('#content');

    this.get('#/', function(context) {
      context.redirect('#/home');
    });

    this.get('#/home', function() {
      console.log('HOME')
    });

    this.get('#/todos', function() {
      templates.get('todos')
        .then(function(template) {
          $content.html(template());
        });

      console.log('TO DO')
    });

    this.get('#/todos/add', function() {
      console.log('TO DO ADD')
    });

    this.get('#/events', function() {
      console.log('EVENTS')
    });

    this.get('#/events/add', function() {
      console.log('EVENTS ADD')
    });

    this.get('#/users', function(context) {
      templates.get('login')
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
                document.location.reload(true);
              });
          });

          $('#btn-register').on('click', function() {
            var user = {
              username: $('#tb-user').val(),
              password: $('#tb-pass').val()
            };

            data.users.register(user)
              .then(function(user) {
                console.log('user is registered')
                toastr.success('User is registered!')
                // context.redirect('#/');
                // document.location.reload(true);
              });
          });
        });

      console.log('USERS')
    });

    this.get('#/users/register', function(context) {
      console.log('REGISTER')
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
