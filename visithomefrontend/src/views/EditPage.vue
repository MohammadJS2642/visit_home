<template>
  <div class="col-12 text-right">
    <div class="row">
      <div class="col-md-3"></div>
      <div class="col-md-6">
        <!-- <form v-model="" action="addData" method="POST"> -->
        <div class="text-danger col"></div>
        <div>
          <input type="hidden" asp-for="UserId" value="@ViewBag.userId" />
        </div>
        <div class="row form-group pb-3">
          <label for="Title" class="control-label col">عنوان</label>
          <input required v-model="Title" id="Title" class="form-control col" />
          <label for="Title" class="control-label col"></label>
          <span class="text-danger col"></span>
        </div>
        <div class="row form-group pb-3">
          <label asp-for="Price" class="control-label col">قیمت</label>
          <input
            type="number"
            required
            v-model="Price"
            class="form-control col"
          />
          <label for="Price" class="control-label col">تومان</label>
          <span asp-validation-for="Price" class="text-danger col"></span>
        </div>
        <div class="row form-group pb-3">
          <label asp-for="Parking" class="control-label col">پارکینگ</label>
          <select v-model="Parking" class="form-control col">
            <option value="false">ندارد</option>
            <option value="true">دارد</option>
          </select>
          <label asp-for="Parking" class="control-label col"></label>
          <span asp-validation-for="Parking" class="text-danger col"></span>
        </div>
        <div class="row form-group pb-3">
          <label for="Warehouse" class="control-label col">انباری</label>
          <select v-model="Warehouse" id="Warehouse" class="form-control col">
            <option value="false">ندارد</option>
            <option value="true">دارد</option>
          </select>
          <label asp-for="Parking" class="control-label col"></label>
          <span asp-validation-for="Warehouse" class="text-danger col"></span>
        </div>
        <div class="row form-group pb-3">
          <label asp-for="Elevator" class="control-label col">آسانسور</label>
          <select asp-for="Elevator" class="form-control col">
            <option value="false">ندارد</option>
            <option value="true">دارد</option>
          </select>
          <label asp-for="Floor" class="control-label col"></label>
          <span asp-validation-for="Elevator" class="text-danger col"></span>
        </div>
        <div class="row form-group pb-3">
          <label asp-for="Floor" class="control-label col">طبقه</label>
          <input type="number" v-model="Floor" class="form-control col" />
          <label asp-for="Floor" class="control-label col"></label>
          <span asp-validation-for="Floor" class="text-danger col"></span>
        </div>
        <div class="row form-group pb-3">
          <label asp-for="Floor" class="control-label col">مساحت</label>
          <input type="number" v-model="Area" class="form-control col" />
          <label asp-for="Floor" class="control-label col"></label>
          <span asp-validation-for="Floor" class="text-danger col"></span>
        </div>
        <div class="row form-group pb-3">
          <label asp-for="Floor" class="control-label col"
            >تعداد اتاق خواب</label
          >
          <input
            type="number"
            v-model="NumberOfBedrooms"
            class="form-control col"
          />
          <label asp-for="Floor" class="control-label col"></label>
          <span asp-validation-for="Floor" class="text-danger col"></span>
        </div>
        <div class="form-group pb-3">
          <label asp-for="Floor" class="control-label">آدرس</label>
          <input v-model="Address" class="form-control" />
          <label asp-for="Floor" class="control-label"></label>
          <span asp-validation-for="Floor" class="text-danger"></span>
        </div>
        <div class="row form-group pb-3">
          <label asp-for="Description" class="control-label"></label>
          <textarea
            v-model="Description"
            placeholder="توضیحات"
            rows="10"
            class="form-control"
          ></textarea>
          <span asp-validation-for="Description" class="text-danger"></span>
        </div>
        <div class="row form-group pb-3">
          <label asp-for="ImageName" class="control-label col"></label>

          <input
            @change="onFileSelected"
            type="file"
            multiple
            name="imgUp"
            placeholder="آپلود"
            accept="image/*"
            asp-for="ImageName"
            class="form-control-file"
          />
          <span asp-validation-for="ImageName" class="text-danger col"></span>
        </div>
        <div class="form-group pt-3 row">
          <!-- <a
            v-if="Title != ''"
            v-on:click="addData"
            class="btn btn-primary col"
            v-bind:href="{ href }"
          >
            ثبت
          </a>
          <a v-else class="btn btn-primary col disabled"> ثبت </a> -->
          <router-link
            class="btn btn-primary col"
            v-on:click="addData"
            :to="{ path: '/homeindex/' + Id }"
          >
            ویرایش
          </router-link>
        </div>
        <!-- </form> -->
      </div>
      <div class="col-md-3"></div>
      <div class="col-md-3"></div>
    </div>
  </div>
</template>

<script lang='ts'>
import { defineComponent } from "vue";
import axio from "axios";
import { uuid } from "vue-uuid";

export default defineComponent({
  name: "EditPage",
  mounted() {
    axio.get("https://localhost:5001/api/Home/" + this.id).then((e) => {
      this.Id = e.data.id;
      this.Area = e.data.area;
      this.NumberOfBedrooms = e.data.numberOfBedrooms;
      this.Parking = e.data.parking;
      this.Warehouse = e.data.warehouse;
      this.Floor = e.data.floor;
      this.Address = e.data.address;
      this.Price = e.data.price;
      this.Title = e.data.title;
      this.Description = e.data.description;
      this.pictures = e.data.pictures;
      this.selectedFile = e.data.selectedfile;
      this.href = "/homeindex/" + e.data.id;
    });
  },
  data() {
    return {
      Id: "",
      Area: "",
      NumberOfBedrooms: "",
      Parking: "",
      Warehouse: "",
      Floor: "",
      Address: "",
      Price: "",
      Title: "",
      Description: "",
      pictures: 0,
      selectedFile: null,
      href: "",
      homeData: [],
    };
  },
  props: ["id"],
  methods: {
    onFileSelected(e: any) {
      console.log(e.target.files);

      this.selectedFile = e.target.files[0].name;
    },
    myAlert() {
      alert("لطفا تمامی اطلاعات را بدرستی وارد نمایید");
    },
    async addData() {
      // console.log(this.Id);
      // console.log(this.Area);
      // console.log(this.NumberOfBedrooms);
      // console.log(this.Parking);
      // console.log(this.Warehouse);
      // console.log(this.Floor);
      // console.log(this.Address);
      // console.log(this.Price);
      // console.log(this.Title);
      // console.log(this.Description);
      // console.log(this.pictures);
      // console.log(this.selectedFile);
      if (this.Title == "") {
        alert("لطفا تمامی اطلاعات را بدرستی وارد نمایید");
      } else {
        let url = `https://localhost:5001/api/Home/${this.Id}/`;
        console.log(url);
        let result = await axio
          .put(url, {
            Id: this.Id,
            Area: this.Area.toString(),
            NumberOfBedrooms: this.NumberOfBedrooms.toString(),
            Parking: this.Parking,
            Warehouse: this.Warehouse,
            Floor: this.Floor.toString(),
            Address: this.Address,
            Price: this.Price.toString(),
            Title: this.Title,
            Description: this.Description,
            PicturesName: this.selectedFile,
          })
          .then((e) => console.log(e));
      }
    },
  },
});
</script>

<style lang="scss" scoped>
</style>
