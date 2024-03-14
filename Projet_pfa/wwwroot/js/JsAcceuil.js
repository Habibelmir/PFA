
  // Récupérer les éléments HTML des boutons et des containers
  const newsButton = document.getElementById('news-button'); //Récupération de l'élément HTML du bouton avec l'id "news-button" et le stocke dans la variable newsButton.
  const journalButton = document.getElementById('journal-button');
  const newsblock = document.querySelector('.news'); //Récupération du 1ér élément HTML qui correspond à la classe "content" à l'intérieur d'un élément avec la classe "container" et le stocke dans la variable containerContent.
  const journalblock = document.querySelector('.journal');

  // Ajouter un écouteur d'événement pour le bouton News
  newsButton.addEventListener('click', function () {
      newsblock.style.display = 'block';
      journalblock.style.display = 'none';
  });

  // Ajouter un écouteur d'événement pour le bouton Journal
  journalButton.addEventListener('click', function () {
      newsblock.style.display = 'none';
      journalblock.style.display = 'block';
  });
