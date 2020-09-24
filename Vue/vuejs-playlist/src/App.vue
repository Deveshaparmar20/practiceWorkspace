<template>
  <div>
    <app-header v-bind:title="title" v-on:changeTitle="updateTitle($event)" />
    <app-ninjas v-bind:ninjas="ninjas" />
    <app-footer v-bind:title="title" />
  </div>
</template>

<script>
import Header from "./components/header.vue";
import Footer from "./components/footer.vue";
import Ninjas from "./components/ninjas.vue";
export default {
  components: {
    "app-header": Header,
    "app-footer": Footer,
    "app-ninjas": Ninjas,
  },
  data() {
    return {
      ninjas: [
        { name: "Ryu", speciality: "Vue Components", show: "false" },
        { name: "Crystal", speciality: "HTML Wizardry", show: "false" },
        { name: "Hitoshi", speciality: "Click Events", show: "false" },
        { name: "Tango", speciality: "Conditionals", show: "false" },
        { name: "Kami", speciality: "Webpack", show: "false" },
        { name: "Yoshi", speciality: "Data diggin", show: "false" },
      ],
      title:"Vue Ninjas"
    };
  },
  methods:{
    updateTitle: function(updatedTitle){
      this.title=updatedTitle
    }
  }
};
</script>
